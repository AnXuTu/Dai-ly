   M S B A M L   `   `   `  ����F  BQuanLyDaiLi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanLyDaiLiQuanLyDaiLi  5   	   K*clr-namespace:QuanLyDaiLi.UserControlLoginQuanLyDaiLi.UserControlLogin  5	      %    QuanLyDaiLi.DanhSachDaiLyWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QuanLyDaiLi     5   	   9uc*clr-namespace:QuanLyDaiLi.UserControlLogin     5	      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   
   -   5          �Name$  Window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     DanhSachDaiLiVM � DataContext# [ 5   	    � Title$ Danh sách đại lý��5   
   $	��400��6#   $	��650��60   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      /   )QuanLyDaiLi.UserControlLogin.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 Window��6J   5       #  MaterialDesignThemes.Wpf.Card  5!   
   $��1��6   $��10q�6+   .��5"      � .+�5#      �� $
��Load��69   $��5q�6H   $	��100��6S   ��6   �� *LoadCommand+6a   5$      5%      � 5&   
   $��2��6   .+�5'        $��2��6"   $��10q�6/   $��Stretch=�6;   .��5(      �� $
��Auto=�6   .��5)      �� ��6   �� *List+ �� SelectedItem 6<   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 5*      �� 5+      .P�5,   "   �� $	��STT��61    �� DisplayMemberBinding 6>   �� *STT+6e   �� 5-   "   $��tên đại lý��61    6E   �� *HoSoDaiLi.TenDaiLy+6{   �� 5.   "   $��Loại đại lý��61    6F   �� *QuyDinh.LoaiDaiLy+6{   �� 5/   "   $��Quận��61    6?   �� *Quan.TenQuan+6o   �� 50   "   $��Tiền nợ��61    6B   �� *TienNo+6l   51      53      54      55      56      57      58      