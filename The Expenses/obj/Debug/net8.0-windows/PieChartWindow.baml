   M S B A M L   `   `   `  ����g  cLiveChartsCore.SkiaSharpView.WPF, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc92a3e13d40c573}Xclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF LiveChartsCore.SkiaSharpView.WPF  5   	    The Expenses!   The_Expenses.PieChartWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   hlvcXclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF     5   	   Aav2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6G     � Title$  PieChartWindow��5   	   $	��450��6    $	��600��6-    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ Manual=�5	   	    � Left$	 150��5
   	   
 � Top$	 150��6    � AllowsTransparency$
 True��5   	   
�������.��5      � $��Center=�6   $	��600��6(    J� RenderTransformOrigin$ 0.739,0.501&�64   .+�5   
   /   )LiveChartsCore.SkiaSharpView.WPF.PieChart  ,   &LiveChartsCore.SkiaSharpView.WPF.Chart   TooltipPosition$ Hidden=�5      $
��Left=�5      $��Center=�5      $	��300��5      $	��300��5      $��20,0,0,0q�6   	   Series	 5      �� *Series+5      �� 5   
   -   5        
 ��Name$
 closeButton��5      $
��Left=�6&   $��	568,0,0,0q�6A   $	��Top=�5      $��32��6)   $��32��64   
������ 
������ .��5      �� $,��&pack://application:,,,/Image/close.png��6   $��28��6D   $��28��6O   5      �� 5   
   -   5         ��Name$ categoriesListBox��5      $��	340,0,0,0q�6-   $
��Left=�6@   $	��223��6[   ��5      �� 5      .R�5      � $��5q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5!      $	��105 �6/   �� 5#      $
��Auto �6/   .+�5(      �� $��20��6$   $��20��6/   $��0,0,10,0q�6Z   $��0��6l   ��6;   �� *CategoryColor+6l   �� 5+      $��Center=�6B   $��1��6]   $��14(�6m   ��6$   �� *CategoryName+6m   �� 5.      $��Center=�6;   $��2��6V   $��10,0,0,0q�6f   $��14(�6x   ��6$   �� *Price+6x   5/      50      52      53      54      