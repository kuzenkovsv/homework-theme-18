   M S B A M L   `   `   `  ����L  Hhomework-theme-18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:homework_theme_18.Viewshomework_theme_18.Views  5   	   ,    &homework_theme_18.Views.NewOrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:homework_theme_18.Views     5   	   -   5        $��NewOrder��5   O     � Title$  NewOrderWindow��6	   $	��300��6    $	��400��6-    � 
ResizeMode$ NoResize=�69   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�62   $
��Wrap=�6O   $��
Почта��5      $��Center=�6!    �� Padding$ 10q�6<   �� 5   
   -   5         ��Name$ ClientEmail��5      $��0��6'   $��1��64   
����� � �� 
IsReadOnly . $
��Left=�5      $��23��6-   $	��170��69   $��Center=�6E    �� TextWrapping$ NoWrap=�5      $��Center=�6(   $�� ��6C   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $
��Wrap=�6N   $��
Товар��5      $��Center=�6!   $ 10q�6<   �� 5   
   -   5         ��Name$ productName��5      $��1��6(   $��1��65   $
��Left=�6E   $��Center=�6`   $	��170��5      $��5q�6   ��6+   �� ��5      �� 5       .R�5!      �� $��productNameText��6    ��67   �� *ProductName+5"      5$      �� 5&   
   $��2��6   $��0��6!   $��Center=�61   $
��Wrap=�6N   $��Количество��5'      $��Center=�6&   $ 10q�6A   �� 5(   
   -   5        $ Quantity��5(      $��2��6%   $��1��62   $
��Left=�6B   $��Center=�6]   $	��170��5)      $��5q�6   .@�5*      �� $��1��6   	 �� 
IsSelected	 . 6'   �� 5+      $��2��6   �� 5,      $��3��6   5-      �� 5/   
   -   5        $��Cancel��5/      $��Отмена��6   $��Center=�60   $��3��50      $��0��6   $��Center=�6.   $��75��6I   
 �� IsCancel
 . 6T   �� 51   
   -   5        $��OrderAdd��51      $��Добавить��6!   $��Center=�64   $��3��52      $��1��6   $��Center=�6.   $��75��6I   ��6T   �� *NewOrderAdd+��53      ��  �� ElementName$ NewOrder��54      55      