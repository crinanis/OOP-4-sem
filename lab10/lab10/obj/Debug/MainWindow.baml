   M S B A M L   `   `   `  ����@  <lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab10lab10  5   	       lab10.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab10     5   	   -   5          � Title$  
MainWindow��5   	   $	��550��6   $	��900��6)    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b    � WindowStyle$
 None=�6�    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 20q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��
 �����6+   5      5      .��5      �� ���	#FFE1E9FF.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
MyBaseGrid��5   /   	   AutoGenerateColumns	 .  $��Center=�6C   $	��900��6`   $	��400��6l   
������ 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Номер аккаунта��6@      
Foreground
 �   �   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *NumAcc+6k     5      $ Тип счёта��6G   $ * 6Z    6%   �� *typeOfDeposit+6Z     5      $* $Дата открытия счёта��6G   $ * 6d    6%   �� *dateOfOpening+6d     5      $ Владелец��6B   $ * 6T    6%   �� *
OwnerAcc+6T   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $
��0 30q�6J   .+�5      �� -   5        ���	#FFC4C0FF.��5   ?   Добавить6I   �� 5      -   5        ���	#FFC4C0FF.��5   B   Удалить6K   �� 5      -   5        ���	#FFC4C0FF.��5   B   Обновить6L   �� 5       -   5         ��Name$ Script��5       $��30��6'   $	��200��63   �� 5!      -   5         ��Name$ Enter_Script��5!      $��Запросы��6+   ���	#FFC4C0FF6R   �� 5"      -   5        ���	#FFC4C0FF.��5"   E   Процедуры6P   5#      �� 5$   
   -	   5        $)��#Добавить владельца��5$   "   $	��150��6?   $��
20 -25 0 0q�6K   $
��Left=�6_   ���	#FFC4C0FF6z   5%      5&      