   M S B A M L   `   `   `  ����B  >Midterm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MidtermMidterm  5   	       Midterm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Midterm     5   	      setImage#���   5   	     � Title$  
MainWindow��5   	   $	��358��6   $��667.6��6)   .��5      ]�   stackStyle2#���  6   .+�5   
   o� $	��Top=�6     	menuStyle#���  6$   .@�5      m� $
��Edit��6     menuItemStyle#���  6&   .@�5      m� $��Themes��6   #���  6+   .@�5      m� -   5         m�Name$ 	darkTheme��5   H   #���  6   $
��Dark��6[   6i   m� 5      -   5        $ 
lightTheme��5   H   #���  6   $��Light��6\   6k   m� 5      -   5        $ SuperSaiyanTheme��5   I   #���  6    $��Super Saiyan��6c   6y   m� 5      -   5        $ default_theme��5   H   #���  6   $��Default��6_   6�   5      5      5      �� 5   
     
stackStyle#���  6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      �� -   5         ��Name$ lbl_size��5   >     
labelStyle#���  6   $��5,0,0,5q�6Q   .��6b   ,*Enter the size of matrix (greater than 5):6�   �� 5      -   5         ��Name$ tb_size��5      $��33��6+   $��Center=�66   $��18��6S   $��5,5,5,10q�6_   5      �� 5      -   5         ��Name$ btn_genMatrix��5   :     btnStyle#���  6   $��Generate the matrix��5      $	��128��5      $
��Left=�6&   $��23��6B   $��15,0,0,0q�6N   �� 5      -   5        $ lbl_enterWord��5   9   #���  6   $��	15,60,0,0q�6P   �� 5       -	   5        $ tb_word��5       $y�Hidden=�6'   $��20,0,0,0q�6;   $	��193��6M   $
��Left=�6Y   �� 5!      -
   5        $ btn_searchWord��5!   8   #���  6   $y�Hidden=�6P   $��	18,15,0,0q�5"   6   $	��128��6J   $
��Left=�6V   $��23��6r   5#      �� 5$   
   $
��Auto=�6   $
��Auto=�6<   .��5%      �� .+�5&      �� .+�5'      � -   5         �Name$ matrixContainer��5'   W     stackStyle3#���  6   $��20,10,10,10q�6B   6W   5(      �� 5)      #���  6   $
��Left=�6C   $��Bottom=�6^   $��10,20q�6y   .+�5*      �� -   5        $ 
lbl_Result��5*      5+      5,      5-      5/      52      