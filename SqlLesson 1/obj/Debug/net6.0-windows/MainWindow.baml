   M S B A M L   `   `   `  ����F  BSqlLesson 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SqlLesson_1SqlLesson_1  5   	       SqlLesson_1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SqlLesson_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   �� $��0��6   $��3q�6   
���   �
����� �._�5      � .+�5      � .+�5      �� -   5        $��id��5   >   $��20(�6   $
��Bold"�6,   $	��200��6H   $��40��6T   $��	50,10,0,0q�6`   �� 5      -   5        $��	firstName��5   >   $��20(�6   $
��Bold"�6,   $	��200��6O   $��40��6[   $��	50,10,0,0q�6g   �� 5      -   5        $��lastName��5   >   $��20(�6   $
��Bold"�6,   $	��200��6N   $��40��6Z   $��	50,10,0,0q�6f   5      5      5      �� 5   
   $��1��6   $��3,0,3,3q�6   
���   �._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��2* �6'   .+�5      � $��0��6   
����� �.+�5      �� .+�5       �� -   5        $��insert��5    !   $	��200��6/   $��50��6;   $��INSERT��6G   $��20(�6X   $
��Bold"�6f   $��30q�6x   6�   �� 5!      -   5        $��delete��5!   !   $	��200��6/   $��50��6;   $��DELETE��6G   $��20(�6X   $
��Bold"�6f   $��30q�6x   6�   �� 5"      -   5        $��showall��5"   !   $	��200��60   $��50��6<   $��SHOWALL��6H   $��20(�6Z   $
��Bold"�6h   $��30q�6z   6�   5#      5$      � 5&      $��1��6   
�������.+�5'      &   System.Windows.Controls.DataGrid  -   5          Name$ 
myDataGrid��5'      66   5(      5)      5*      5+      5,      