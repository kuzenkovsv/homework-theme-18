   M S B A M L   `   `   `  ����L  Hhomework-theme-18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:homework_theme_18.Viewshomework_theme_18.Views  5   	   -    'homework_theme_18.Views.AddClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:homework_theme_18.Views     5   	   -   5        $��	NewClient��5   S     � Title$)  #Добавление клиента��6	   $	��300��6$   $	��400��61    � 
ResizeMode$ NoResize=�6=   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�62   $
��Wrap=�6O   $��ФИО��5      $��Center=�6    �� Padding$ 10q�6:   �� 5   
   -   5         ��Name$ 
ClientName��5      $��0��6&   $��1��63   
����� � � ToolTip$* $Введите имя клиента��6U   $
��Left=�5      $��23��6-   $	��170��69   $��Center=�6E    �� TextWrapping$ NoWrap=�5      $��Center=�6(   $�� ��6C   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $
��Wrap=�6N   $��Телефон��5      $��Center=�6#   $ 10q�6>   �� 5   
   -   5        $	 Tel��5      $��1��6   $��1��6,   $2 ,Введите телефон клиента��6<   $
��Left=�5      $��23��6-   $	��170��69   $��Center=�6E   $ NoWrap=�5      $��Center=�6(   $�� ��6C   �� 5!   
   $��2��6   $��0��6!   $��Center=�61   $
��Wrap=�6N   $��
Почта��5"      $��Center=�6!   $ 10q�6<   �� 5#   
   -   5        $ Email��5#      $��2��6!   $��1��6.   $) #Введите Email клиента��6>   $
��Left=�5$      $��23��6-   $	��170��69   $��Center=�6E   $ NoWrap=�5%      $��Center=�6(   $�� ��6C   �� 5'   
   -   5        $��Cancel��5'      $��Отмена��6   $��Center=�60   $��3��5(      $��0��6   $��Center=�6.   $��75��6I    �� IsCancel . 6T   �� 5)   
   -   5        $��	ClientAdd��5)      $��Добавить��6"   $��Center=�65   $��3��5*      $��1��6   $��Center=�6.   $��75��6I   ��6T   �� *
Add1Client+��5+      �� 	 �� ElementName$	 	NewClient��5-      5.      