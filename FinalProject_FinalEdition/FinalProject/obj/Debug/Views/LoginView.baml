   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalProject.ViewsFinalProject.Views 5   	   "   FinalProject.Views.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   2local clr-namespace:FinalProject.Views     5   	   -   5        $��login��5   "     � Title$  	LoginView��5	   	   &   System.Windows.Media.TextOptions   TextRenderingMode$
 Auto=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $	��450��5   	   $	��800��6    � SizeToContent$ WidthAndHeight=�6/   .��5      � .+�5   
   �� -   5        $��LoginHeading��5      $��23��5      $
��Left=�5      $��	10,10,0,0q�5      $��Login:��5   (   $	��Top=�5      $��18(�5      $��Times New Roman)�5      $
��Bold"�5      �� 5   
   -   5        $��textBlockHeading��5      $��50��5      $
��Left=�5      $��	24,48,0,0q�5      $	��Top=�5      $��14(�5      $��Times New Roman)�5      $��Italic$�5       �� Padding$ 5q�5      <:Note: Please login here to view the features of this site.�� 5   I   31If you are new on this site then please click on �� 5"      �� 5#      -   5        $��14(�5#   :   $��Normal$�6H   $��Times New Roman)�6[   .�6x   
Register6�   5$      	 button5'      �� 5(   
   -   5        $��
textBlock1��5,      $��23��5(      $��Times New Roman)�5)      $
��Left=�5*      $��
66,120,0,0q�5+      $��Email��5-      $	��Top=�5.      $��14(�5/      $��67��50      �� 51   
   -   5        $��
textBlock2��56      $��23��51      $��Times New Roman)�52      $��14(�53      $
��Left=�54      $��
58,168,0,0q�55      $��Password��57      $	��Top=�58      $��77��59      �� 5:   
   -   5        $��textBoxEmail��5=   B   $��23��5:      $��Times New Roman)�5;      $��14(�5<      $
��Left=�5=      $��118,117,0,0q�6-   $	��Top=�6V   $	��150��6n   G� 5>   
   -   5        $��passwordBox1��5>   R   $��23��6   $
��Left=�6"   $��118,165,0,0q�6=   $	��Top=�6f   $	��150��6~   �� 5?   
   -	   5        $��button1��5?   �      AccentedSquareButtonStyle#��[  6   $��30��6D   $
��Left=�6P   $��118,211,0,0q�6k   $	��Top=�6�   $	��104��6�   .��5@      �� $��Login��6   $��14(�5A   !   $��Times New Roman)�5B   !   6@   5C      �� 5D   
   -
   5         ��Name$ errormessage��5G      $��23��5D      $
��Left=�6    $��Times New Roman)�5E      $��14(�5F      $	��Top=�5G   +   $	��247��6C   $��118,253,0,0q�6O    J� OpacityMask
 �<�����	#FFE5572C6{   5H      5I      