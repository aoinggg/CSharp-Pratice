   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  	_myWindow��5   5    � Title$ 
MainWindow��6	   $	��350��6   $	��800��6)   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��1��6;   .+�5      �� -   5         ��Name$ Start��5      $	��100��6$   $��Start��60   6@   �� 5      -   5        $
 Stop��5      $	��100��6#   $
��Stop��6/   $
��10,0q�6>   6L   5         WpfApp1.UserControl1  5   
   -   5          Name$ _myUserControl��5      $��1��65   $��1��6B      DisplayLineWidth$	 500��5         DisplayxLabelInterval$	 100��64   	   ReFreshInterval$	 10��6P   
   yValue
 5      ��  �� ElementName$ mySlider�� �� Path$ Value��� 5   
   -   5         ��Name$ mySlider��5      $��1��6#   $��0��60    �� Orientation$ Vertical=�6@   $��Center=�6W    � Minimum$ 0Q�5       � Maximum$	 200Q�6   5      5      