   M S B A M L   `   `   `  ���� g  cLiveChartsCore.SkiaSharpView.WPF, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc92a3e13d40c573}Xclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF LiveChartsCore.SkiaSharpView.WPF   The Expenses!   The_Expenses.PieChartWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     hlvcXclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF     Aav2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  PieChartWindow��$	��450��$	��600�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ Manual=� � Left$	 150��
 � Top$	 150�� � AllowsTransparency$
 True�����#FEF9D9 � 	Resources     BooleanToVisibilityConverter��%   &	        �� .��� -    �Name$
 grid��$
��Left=�$
��1036��	 J� RenderTransformOrigin$	 0.739,0.501&�.+�/   )LiveChartsCore.SkiaSharpView.WPF.PieChart  ,   &LiveChartsCore.SkiaSharpView.WPF.Chart
   TooltipPosition$
 Hidden=�$
��Left=�$��Center=�$	��300��$	��300��$��22,0,0,0q�   Series �� *Series+�� -    ��Name$ closeButton��$
��Left=�$��	568,0,0,0q�$	��Top=�$��32��$��32��
������ 
������ .���� $,��&pack://application:,,,/Image/close.png��$��28��$��28���� -    ��Name$ categoriesListBox��$��	340,0,0,0q�$
��Left=�$	��223��$	��404��$	��Top=����� .R�� $��5q� � ColumnDefinitions �� $
��Auto ��� $	��105 ��� $
��Auto ��� $
��Auto �.+��� $��20��$��20��$��0,0,10,0q�$��0������ *CategoryColor+�� $��Center=�$��1��$��14(����� *CategoryName+�� $��Center=�$��2��$��10,0,0,0q�$��14(����� *Price+�� -   $ expensesListBox��$��	0,0,128,0q�$	��335��$	��Top=�$��Right=�$	��444��$y�	Collapsed=����� .R�9� $��14(����� *Date+.���� $��14(����� *	Purchases+���� .R���  �� Orientation$ 
Horizontal=�$
��10,5q�.+��� $��25��$��Center=�$��14(� d� 	IsChecked �� *IsDeleteVisible+ �� Mode$ TwoWay=��� $	��120��$��Center=�$��14(����� *CategoryName+�� $��60��$��Center=�$��14(����� *Price+�� $��35��$��Center=�$��14(����� *Time+�� -   $��Удалить��$��60��$��25��$��10,0,0,0q�$��14(�y��� *IsDeleteVisible+ �� 	Converter# [  �� -   $ expensesButton��$��Расходы��$
��Left=�$��
10,409,0,0q�$	��Top=�$��35��$	��111��$��16(��� -    ��Name$ allSumTextBox�� �� TextAlignment$ Center=�$��Center=�$
��Left=�$��417,409,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��146��$��35��$��16(� �� 
IsReadOnly$
 True���� -   $ allSumInfoTextBox��$ Center=�$��Center=�$
��Left=�$��340,409,0,0q�$
 Wrap=�$��
Сумма��$	��Top=�$��72��$��35��$��16(�$
 True���� -	   $ turnLeft��$
��Left=�$��	908,0,0,0q�$��Center=�$��32��$��32��$y�Visible=�
������ 
������ .���� $/��)pack://application:,,,/Image/turnLeft.png��$��28��$��28��