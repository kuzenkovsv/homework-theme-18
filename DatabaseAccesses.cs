using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace homework_theme_18
{
    public class DatabaseAccesses
    {
        // Метод добавления клиента
        public BeanMagas AddClientMethod(string name, string tel, string email)
        {
            BeanMagas db = new BeanMagas();

            Clients newcl = new Clients
            {
                LFMName = name,
                Telephone = tel,
                Email = email
            };
            db.Clients.Add(newcl);
            db.SaveChanges();
            db.Clients.Load();
            return db;
            
        }

        // Метод удаления клиента
        public BeanMagas DelClientMethod(int id)
        {
            BeanMagas db = new BeanMagas();

            Clients client = db.Clients.Find(id);
            db.Clients.Remove(client);

            db.SaveChanges();
            db.Clients.Load();
            return db;
        }

        // Метод покааза истории заказов (выборка по email)
        public List<Orders> ShowOrdersByEmailMethod(string email)
        {
            BeanMagas db = new BeanMagas();
            db.Orders.Load();
            List<Orders> history = new List<Orders>();
            int a = 20 - email.Length;

            foreach (var item in db.Orders)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (a == 13 & item.ClientEmail == $"Email_{i}             " & item.ClientEmail.Contains(email))
                    {
                        history.Add(item);
                    }
                }

                if (a == 12 & item.ClientEmail.Contains(email))
                {
                    history.Add(item);
                }

            }

            return history;
        }

        // Метод редактирования клиента
        public BeanMagas EditClientMethod(int ID, string name, string tel, string email)
        {
            BeanMagas db = new BeanMagas();

            Clients client = db.Clients.Find(ID);
            client.LFMName = name;
            client.Telephone = tel;
            client.Email = email;

            db.SaveChanges();

            db.Clients.Load();
            return db;
        }

        // Метод для подгрузки списка товаров
        public BeanMagas LoadProductMethod()
        {
            BeanMagas db = new BeanMagas();
            db.Product.Load();

            return db;
        }


        // Метод создания заказа
        public BeanMagas AddOrderMethod(string email, int idProduct, string productName, int quantity)
        {
            BeanMagas db = new BeanMagas();

            Orders nOrd = new Orders
            {
                ClientEmail = email,
                IdProduct = idProduct + 1,
                ProductName = productName,
                Quantity = quantity
            };
            db.Orders.Add(nOrd);
            db.SaveChanges();
            db.Orders.Load();
            return db;
        }

    }
}
