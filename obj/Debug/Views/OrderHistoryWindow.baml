   M S B A M L   `   `   `  ����L  Hhomework-theme-18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:homework_theme_18.Viewshomework_theme_18.Views  5   	   0    *homework_theme_18.Views.OrderHistoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:homework_theme_18.Views     5   	   -   5        $��
ordHistory��5   P     � Title$#  История заказов��6	   $	��450��6!   $	��500��6.    � 
ResizeMode$ NoResize=�6:   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��95* �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ history��5      $��0��6$   $��0��61   $��3��6A      AutoGenerateColumns .     
IsReadOnly . ��5   ;   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        orderId��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5   M   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 20 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Id+6k     5      -   5        ordClientEmail��$ 
Почта��5   ]   $	
 100 6l    6=   �� *ClientEmail+6l     5      -   5        	ordProdId��$ ID товара��5   V   $
 80 6i    68   �� *	IdProduct+6i     5      -   5        ordProdName��$ Наименование��5   Z   $	
 170 6p    6:   �� *ProductName+6p     5       -   5        ordQuant��$  Количество, кг��5    T   $	
 100 6l    67   �� *
Quantity+6l   5#      5%      5'      