   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FinalProject.ViewModelsFinalProject.ViewModels 5   	   )   #FinalProject.Views.RegistrationView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:FinalProject.ViewModels     5   	   -   5        $��registration��5	   ;     � Title$  RegistrationView��6	   $	��600��6"   $	��800��6/   &   System.Windows.Media.TextOptions   TextRenderingMode$
 Auto=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � SizeToContent$ WidthAndHeight=�5   	   .��5      � $	��500��6   $	��525��6   
��� ���.+�5   
   �� -   5        $��textBlockHeading��5   M   $��23��6   $
��Left=�6    $��10,5,0,0q�6;   $��Registration:��6e   $	��Top=�6z   $	��110��6�   $��18(�5      $��Times New Roman)�5      $
��Bold"�5      �� 5   
   -   5        $��451,5,12,288q�5      $��Times New Roman)�6'   $��14(�5       � Cursor$
 Hand��6"   ��5      �� 5       �� 
TargetType" ��6"   .R�5      �� $��	Underline{�6    $��Login��5       �� 5      5      5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��  �63   	 �� Triggers	 5       P� 5!      
 P� Property
 �@J�IsMouseOver P� Value . . �5"      ��  � ��
 �  ��6;   5#      5%      5'      � 5)   
   $��
31,0,29,23q�6   
�������$��Bottom=�66    � ColumnDefinitions 5*      �� 5+      $��5* �6#   60   �� 5,      $��5* �6#   60    � RowDefinitions 5.      �� 5/      $��5* �6    6.   �� 50      6"   .+�52      �� -   5         ��Name$ errormessage��55   E   $��20��52      $��Times New Roman)�53      $��14(�54      $
��Left=�55      $��40,0,0,0q�63   $	��Top=�6\   $	��247��6t    J� OpacityMask
 �<�����	#FFE5572C6�   �� 56      $��0��6   $��0��6)   .+�57      �� -   5        $��textBlockFirstname��5:   O   $��23��57      $��14(�58      $��Times New Roman)�59      $
��Left=�5:      $��10, 30, 10, 10q�67   $��First Name:��6i   $	��Top=�6|   �� 5<      -   5        $��textBlockLastName��5?   C   $��23��5<      $��14(�5=      $��Times New Roman)�5>      $
��Left=�5?      $��10q�67   $��
Last Name:��6\   $	��Top=�6n   �� 5A      -   5        $��textBlockEmailId��5D   C   $��23��5A      $��14(�5B      $��Times New Roman)�5C      $
��Left=�5D      $��10q�67   $��Email:��6[   $	��Top=�6i   �� 5E      -   5        $��textBlockPassword��5H   C   $��23��5E      $��14(�5F      $��Times New Roman)�5G      $
��Left=�5H      $��10q�67   $��	Password:��6\   $	��Top=�6m   �� 5I      -	   5        $��textBlockConfirmPwd��5L   C   $��23��5I      $��14(�5J      $��Times New Roman)�5K      $
��Left=�5L      $��10q�67   $��ConfirmPassword:��6^   $	��Top=�6v   $��2��5M      �� 5N      -
   5        $��textBlockAddress��5R   (   $��23��5N      $��14(�5O      $��Times New Roman)�5P      $
��Left=�5Q      $��10q�5R      $��Date: (YYYY/MM/DD)��6@   $	��Top=�6Z   �� 5S      -   5        $��textBlockPhone��5V   C   $��23��5S      $��14(�5T      $��Times New Roman)�5U      $
��Left=�5V      $��10q�67   $��Phone number:��6Y   $	��Top=�6n   5X      �� 5Y      $��1��6   $��0��6)   .+�5Z      �� -   5        $��textBoxFirstName��5]   I   $��20��5Z      $��Times New Roman)�5[      $��14(�5\      $
��Left=�5]      $��
0,30,10,10q�65   $	��175��6b   �� 5^      -   5        $��textBoxLastName��5a   H   $��20��5^      $��Times New Roman)�5_      $��14(�5`      $
��Left=�5a      $��	0,5,10,10q�65   $	��175��6_   �� 5b      -   5        $��textBoxEmail��5e   H   $��20��5b      $��Times New Roman)�5c      $��14(�5d      $
��Left=�5e      $��	0,5,10,10q�65   $	��175��6]   G� 5f      -   5        $��passwordBox1��5f   X   $��20��6   $
��Left=�6*   $��	0,7,10,10q�6E   $	��175��6m   G� 5g      -   5        $��passwordBoxConfirm��5g   X   $��23��6   $
��Left=�6*   $��	0,8,10,10q�6E   $	��175��6s   �� 5h      -   5        $��textBoxDate��5k   H   $��23��5h      $��Times New Roman)�5i      $��14(�5j      $
��Left=�5k      $��	0,5,10,10q�65   $	��175��6\   �� 5l      -   5        $��textBoxPhone��5o   H   $��23��5l      $��Times New Roman)�5m      $��14(�5n      $
��Left=�5o      $��	0,8,10,10q�65   $	��175��6]   5p      � 5q      $��2��6   $��	0,333,0,0q�6,   $��2��6?   $��Center=�6P   .+�5r      �� -   5        $��Submit��5u      $��30��5r      $��Center=�5s      $��10q�5t      $��70��5v         AccentedSquareButtonStyle#��[  5x      .��5y      �� $��Register��6    $��14(�5z   !   $��Times New Roman)�5{   !   6@   5|      �� 5}      -   5        $��button2��5}   L   $��30��6   $��Center=�6%   $��10q�6@   $��70��6\   #��[  6}   .��5~      �� $��Reset��6    $��14(�5   !   $��Times New Roman)�5�   !   6@   5�      �� 5�      -   5        $��button3��5�   L   $��30��6   $��Center=�6%   $��10q�6@   $��70��6\   #��[  6}   .��5�      �� $��Cancel��6    $��14(�5�   !   $��Times New Roman)�5�   !   6@   5�      5�      5�      5�      5�      