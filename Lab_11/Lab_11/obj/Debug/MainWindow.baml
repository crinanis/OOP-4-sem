   M S B A M L   `   `   `  ����A  =Lab_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab12lab12  5   	       lab12.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab12     5   	     � Title$  lab12��5   	   $	��450��6   $	��800��6$   ���	#FFE5E4FB � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $
��197* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
authorGrid��5   L   
������    AutoGenerateColumns .  $��2��6`   $��5,0,5,46q�6t   $��2��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *id+6L     5      $

 Name��6B   $ * 6P    6)   �� *name+6P     5      $
 BookID��6D   $ * 6T    6)   �� *bookID+6T   5       5!      � 5"   
   $��0��6   $��0��6   .+�5#      ��  �� Orientation$ Vertical=�6   $��	10,0,10,0q�60   .+�5$      �� $
��name��6   �� 5%      -   5         ��Name$ TextBox_Name��5%      5&      5'      �� 5(   
   $��Center=�6   $��1��63   $ 
Horizontal=�6@   $��2��6Y   $��31,0.4,46.6,0q�6m   $	��716��6�   .+�5)      �� -   5         ��Name$ updateButton��5)      $��Обновить��6+   6>   �� 5*      -   5        $ deleteButton��5*      $��Удалить��6+   6=   �� 5+      -   5        $ 	addButton��5+      $��Добавить��6(   6;   �� 5,      -   5        $ queryButton��5,      $��Запрос��6*   6;   �� 5-      -   5        $ updateItemButton��5-      $#��Обновить запись��6/   6I   5.      5/      50      