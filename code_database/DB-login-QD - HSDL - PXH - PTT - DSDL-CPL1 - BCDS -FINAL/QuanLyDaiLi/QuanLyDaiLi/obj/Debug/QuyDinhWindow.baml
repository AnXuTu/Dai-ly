   M S B A M L   `   `   `  ����F  BQuanLyDaiLi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanLyDaiLiQuanLyDaiLi  5   	   K*clr-namespace:QuanLyDaiLi.UserControlLoginQuanLyDaiLi.UserControlLogin  5	   
       QuanLyDaiLi.QuyDinhWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QuanLyDaiLi     5   	   9uc*clr-namespace:QuanLyDaiLi.UserControlLogin     5	   
   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   
   -   5          �Name$  Window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     	QuyDinhVM � DataContext# [ 5   	    � Title$ Quy định��5   	   $	��400��6   $	��450��6'   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      /   )QuanLyDaiLi.UserControlLogin.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 Window��6J   5      � 5    
   $��1��6    5!      �� 5"      $
��auto �6    60   �� 5#      $
��auto �6    60   �� 5$      6"   .+�5'      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5(      � .+�5)      �� $��5q�6k   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Loại đại lý��5*       % !MaterialDesignFloatingHintTextBox#��[ 5+      ��5)      �� *	LoaiDaiLy+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5+      �� 5,      $��5q�6i   $ Tiền nợ tối đa��5-      #��[ 5.      ��5,      �� *	SoLuong+$ PropertyChanged=�$ TwoWay=�5.      5/      50        51      $��1��6"   $��5q�6/   .��52      � .+�53      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 54      $��Sửa��6=   $��5q�6K   $	��100��6V   ��6   �� *EditCommand+6d   56      57        58      $��2��6"   $��5q�6/   $��Stretch=�6:   .��59      �� $
��Auto=�6   .��5:      �� ��6   �� *List+ �� SelectedItem 6<   �� *SelectedItem+$ TwoWay=� �� View 5;      �� 5<      .P�5=   "   �� $��Loại đại lý��61    �� DisplayMemberBinding 6F   �� *	LoaiDaiLy+6s   �� 5>   "   $��Tiền nợ tối đa��61    6I   �� *	SoLuong+6t   5?      5A      5B      5C      5D      5E      5F      