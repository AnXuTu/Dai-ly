   M S B A M L   `   `   `  ����F  BQuanLyDaiLi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuanLyDaiLiQuanLyDaiLi  5   	   K*clr-namespace:QuanLyDaiLi.UserControlLoginQuanLyDaiLi.UserControlLogin  5	   	   $    QuanLyDaiLi.BaoCaoDanhSoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QuanLyDaiLi     5   	   9uc*clr-namespace:QuanLyDaiLi.UserControlLogin     5	   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   
   -   5          �Name$  Window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     BaoCaoDoanhSoVM � DataContext# [ 5   	    � Title$ Báo cáo doanh số��5   	   $	��400��6"   $	��650��6/   .��5      � $	��400��6   $	��Top=�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      /   )QuanLyDaiLi.UserControlLogin.ControlBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 Window��6J   5      � 5    
   $��1��6    5!      �� 5"      $
��auto �6    60   �� 5#      $
��auto �6    60   �� 5$      6"   .+�5'      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5(      � $��0 0 0 10q�6   .+�5)      (  "System.Windows.Controls.DatePicker  $��5 5 15 5q�6e   $��Center=�6w   $
��Left=�6�   $	��100��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tháng��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6!   �� *Thang+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5*      5+        5,      $��1��6"   $��5q�6/   .��5-      � .+�5.      �� $
��Load��6=   $��5q�6L   $	��100��6W   ��6   �� *LoadCommand+6e   5/      50        51      $��2��6"   $��5q�6/   $��Stretch=�6:   .��52      �� $
��Auto=�6   .��53      �� ��6   �� *List+ �� View 54      �� 55      .P�56   "   �� $	��STT��61    �� DisplayMemberBinding 6>   �� *STT+6e   �� 57   "   $��tên đại lý��61    6E   �� *HoSoDaiLi1.TenDaiLy+6|   �� 58   "   $��Số phiếu xuất��61    6H   �� *SoPhieuXuat+6w   �� 59   "   $��Tổng giá trị��61    6G   �� *
TongGiaTri+6u   �� 5:   "   $��	Tỷ lệ��61    6@   �� *TyLe+6h   5;      5=      5>      5?      5@      5A      5B      