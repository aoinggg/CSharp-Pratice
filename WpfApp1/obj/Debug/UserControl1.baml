   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.UserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        � 	Resources  5         _myDrawingBrush j� Viewport j� ViewportUnits j� TileMode L� Drawing � Geometry � Brush��%  &	        L� 5	   
   $ 	0,0,50,50�6/   $ Absolute=�6D   $
 Tile=�6]    5
      I� 5      ��5      � + ��        �@B     �@B '  �    '  	
 ��ح�6P   � 5      + ��        �    @B �'  @B �'      	
 ��ح�6P   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      .+�5   
   �� 	 J� RenderTransformOrigin$	 0.5,0.5&�6   $��2q�61   
���   �}�. $��0��5      $��1��6   z�5       �� 5!      
 �� ScaleY$
 -1Q�6!   ._�5#      �� -   5         ��Name$ myCanvas��5#      #��[  6'   .+�5$      � -   5        $��
myPolyLine��5$      $��2��6-   
���  ��6A   5%      5&      � 5(   
   -   5         �Name$ yGrid��5(      $��0��6   $��0��6+   $��Bottom=�6;   $��Center=�6V   � 5)   
   $��1��6   $��1��6   }�. .+�5*      �� -   5        $ xCanvas��5*      5+      5-      5.      