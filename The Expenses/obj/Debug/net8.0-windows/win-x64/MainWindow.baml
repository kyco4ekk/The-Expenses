   M S B A M L   `   `   `  ����g  cLiveChartsCore.SkiaSharpView.WPF, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc92a3e13d40c573}Xclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF LiveChartsCore.SkiaSharpView.WPF  5   	    The Expenses   The_Expenses.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   hlvcXclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��260��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ Manual=�5   	    � Left$	 150��5   	   
 � Top$	 150��6    � AllowsTransparency$
 True��5   	   
�������.��5      � .+�5   
   �� -   5         ��Name$ 	addButton��5      $��Добавить��6$   $
��Left=�67   $��
72,258,0,0q�6R   $	��Top=�6f   $	��110��6~   $��39��6�   $��16(�6�   6�   �� 5   
   -   5        $ showPieChartButton��5      $��График��6-   $
��Left=�6>   $��	72,68,0,0q�6Y   $	��Top=�6l   $��29��6�   $	��110��6�   $��16(�6�   6�   �� 5   
   -   5         ��Name$ priceTextBox��5      $
��Left=�6(   $��
25,162,0,0q�6C   	 �� TextWrapping$
	 Wrap=�6W   $�� ��6k   $	��Top=�6s   $��70��6�   $��30��6�   $��18(�6�   6�   �� 5   
   -   5        $ currencyTextBox��5      $
��Left=�6+   $��
95,162,0,0q�6F   $
	 Wrap=�6Z   $	��₽��6n   $	��Top=�6w   $��20��6�   $��30��6�   $��18(�6�   
 �� 
IsReadOnly$

 True��6�   �� 5   
   -   5        $ closeButton��5      $
��Left=�6&   $��	228,0,0,0q�6A   $	��Top=�5      $��32��61   $��32��6<   
������ 
������ .��5      �� $,��&pack://application:,,,/Image/close.png��6   $��28��6D   $��28��6O   5      �� 5   
   -   5         ��Name$ categoryComboBox��5      $
��Left=�6-   $��120,162,0,0q�6H   $	��Top=�6]   $	��124��6u   $��30��6�   6�   5       � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%c  '��       '�� H     �� 5    
   " ��6   .�5!      ��  � ��$ 16(�6)   5"      �� 5%   
   " ��6    5&      P� 5'       �@J�IsKeyboardFocusWithin$
 True��6;   . �5(      ��  � ��$ 16(�61   5)      P� 5*       �@J�IsKeyboardFocusWithin$ False��6;   . �5+      ��  � ��$ 16(�61   5,      5.      5/      50      