   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��300��6(   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Elements de la llista:��6   $��0��62   $��1��6?   $��Bottom=�6O   $
��Wrap=�6j   �� 5   
   $!��Afegeix element a la llista��6   $��0��67   $��3��6D   $��Bottom=�6T   $
��Wrap=�6o   �� 5   
   $��1��6   $��3��6"    �� Orientation$ Vertical=�62   .+�5       �� -   5        $��txtNouElement��5       �� 5!      -   5        $��Afegeix��5!      6'   5"      �� 5#   
   $��Treu element de la llista��6   $��2��65   $��3��6B   $��Bottom=�6R   $
��Wrap=�6m   �� 5$   
   $��3��6   $��3��6"   $ Vertical=�62   .+�5%      �� -   5        $��txtTreuElement��5%      �� 5&      -   5        $��Elimina��5&      6'   5'      �� 5(   
   $��1��6   $��1��6'   $��3��64   .��5)      �� -   5        $��txtBMostrar��5)      $�� ��6,   ��. 65   5*      �� 5+   
   $��Existeix a la llista?��6   $��4��61   $��3��6>   $��Bottom=�6N   $
��Wrap=�6i   �� 5,   
   $��5��6   $��3��6"   $ Vertical=�62   .+�5-      �� -   5        $��
txtCompara��5-      �� 5.      -   5        $��Cerca��5.      6%   5/      54      58      