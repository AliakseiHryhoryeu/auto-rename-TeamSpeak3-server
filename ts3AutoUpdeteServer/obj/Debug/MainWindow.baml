   M S B A M L   `   `   `  ����N  Jts3AutoUpdeteServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ts3AutoUpdeteServerts3AutoUpdeteServer  5   	   $    ts3AutoUpdeteServer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ts3AutoUpdeteServer     5   	     � Title$  Auto rename server��5   	   $	��450��6$   $
��1200��61    � WindowStartupLocation$ CenterScreen=�6>   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5        $��30��5      $��30��6   $
��Left=�6(   $��10 0 0 0q�6C   .��5      �� $5��/pack://application:,,,/Resources/RunBlue111.png��6   $y�Visible=�6M   5      �� 5   
   -   5        $��30��5      $��30��6   $
��Left=�6(   $��50 0 0 0q�6C   .��5      �� $3��-pack://application:,,,/Resources/addBlue2.png��6   $y�Visible=�6K   5      �� 5   
   -   5        $��30��5      $��30��6   $
��Left=�6(   $��90 0 0 0q�6C   .��5      �� $0��*pack://application:,,,/Resources/edit1.png��6   $y�Visible=�6H   5      �� 5   
   -   5        $��30��5      $��30��6   $
��Left=�6(   $��	130 0 0 0q�6C   .��5      �� $3��-pack://application:,,,/Resources/Garbage2.png��6   $y�Visible=�6K   5      �� 5   
   -   5        $��30��5      $��30��6   $
��Left=�6(   $��	170 0 0 0q�6C   .��5      �� $2��,pack://application:,,,/Resources/update1.png��6   $y�Visible=�6J   5      �� 5   
   -   5        $��30��5      $��30��6   $
��Left=�6(   $��	210 0 0 0q�6C   .��5      �� $4��.pack://application:,,,/Resources/settings1.png��6   $y�Visible=�6L   5      �� 5    
   -   5        $��30��5       $��30��6   $
��Left=�6(   $��	250 0 0 0q�6C   .��5!      �� $0��*pack://application:,,,/Resources/info2.png��6   $y�Visible=�6H   5"      �� 5#   
   -   5        $
��Bold"�5#      $��18(�6#   $��30��61   $	��300��6=   $
��Left=�6I   $��	290 0 0 0q�6d   .��6�   Start AutoUpdate5%      �� 5&   
   -	   5        $��secondsBlock��5&      $
��Left=�6(    �� TextAlignment$ Center=�6C   $��20(�6Z   $��	595,5,0,0q�6h   $
��Wrap=�6{   $��	0 Seconds��6�   $	��Top=�6�   $��30��6�   $	��387��6�   � 5(   
   $��1��6   .+�5)      &   System.Windows.Controls.DataGrid  -
   5          Name$ dgTableServers��5)         AutoGenerateColumns .  $��10q�6K      Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 №��6]   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 6h   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   ��  �� Path$ ServerId�6h     5,       . $ login��6Z   $	 * 6i   
 6)   �� $ Login�6i     5-       . $ Password��6]   $	 * 6o   
 6)   �� $ Password�6o     5.       . $ 	Server ip��6]   $	 * 6p   
 6)   �� $ ServerIp�6p     5/       . $ Name1��6Z   $	 * 6i   
 6)   �� $ Name1�6i     50       . $ Name2��6Z   $	 * 6i   
 6)   �� $ Name2�6i     51       . $ 
DateUpdate��6_   $	 * 6s   
 6)   �� $ 
DateUpdate�6s   54      55      56      57      