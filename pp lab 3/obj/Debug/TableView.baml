   M S B A M L   `   `   `  ����C  ?pp lab 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:pp_lab_3pp_lab_3  5   	       pp_lab_3.TableView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:pp_lab_3     5   	     � Title$  	TableView��5   	   $	��459��6   $	��808��6(    � 
ResizeMode$ NoResize=�64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridView1��5
      $
��Left=�6*   $	��346��6E   $��	10,10,0,0q�6R   $	��Top=�6e   $	��772��6}    J� RenderTransformOrigin$	 1,1&�6�   �� 5   
   $+��%Поиск по базе данных��6   $
��Left=�61   $��53��6L   $��
10,356,0,0q�6X   $	��Top=�6l   $	��570��6�   .��5      � $
��Left=�6   $��31��63   $��	0,1,-2,-2q�6?   $	��Top=�6R   $	��560��6j   .+�5      �� $��Столбец:��6   �� 5      -   5         ��Name$ columns��5      $	��120��6,   68   �� 5      $��Значение:��6   �� 5      -   5         ��Name$ textBox1��5      $��22��6,    �� TextWrapping$
 Wrap=�68   $	��283��6L   5      5      �� 5   
   -   5         ��Name$
 save��5      $��Сохранить��6   $
��Left=�63   $��691,361,0,0q�6N   $	��Top=�6c   $��91��6{   $��48��6�   $��16(�6�   6�   �� 5   
   -   5        $ refresh��5      $
��🔄��6"   $
��Left=�6/   $��638,361,0,0q�6J   $	��Top=�6_   $��48��6w   $��48��6�   $��20(�6�   6�   �� 5   
   -   5        $ delete��5      $��🗑️��6!   $
��Left=�6/   $��585,361,0,0q�6J   $	��Top=�6_   $��48��6w   $��48��6�   $��20(�6�   6�   �� 5   
   -   5        $ search��5      $
��🔎��6!   $
��Left=�6.   $��547,374,0,0q�6I   $	��Top=�6^   $��25��6v   $��25��6�   $��14(�6�   6�   5      5      