   M S B A M L   `   `   `  ����   The Expenses!    The_Expenses.ExpensesWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  ExpensesWindow��$	��450��$	��420�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ Manual=� � Left$	 150��
 � Top$	 150�� � AllowsTransparency$
 True��
������� � 	Resources     BooleanToVisibilityConverter��%   &	        �� .��� .+��� -    ��Name$ closeButton��$
��Left=�$��	388,0,0,0q�$	��Top=�$��32��$��32��
������ 
������ .���� $,��&pack://application:,,,/Image/close.png��$��28��$��28���� -   	 ��Name$	 expensesListBox��$��	10,0,37,0q�$	��Top=����� .R�9� $��14(����� *Date+.���� $��14(����� *	Purchases+���� .R��� 
 �� Orientation$
 
Horizontal=�$
��10,5q�.+��� $��30��$��Center=�$��14(� d� 	IsChecked �� *IsDeleteVisible+ �� Mode$ TwoWay=��� $	��120��$��Center=�$��14(����� *CategoryName+�� $��70��$��Center=�$��14(����� *Price+�� $��40��$��Center=�$��14(����� *Time+�� -   $��Удалить��$��70��$��25��$��10,0,0,0q�$��14(�y��� *IsDeleteVisible+ �� 	Converter# [  