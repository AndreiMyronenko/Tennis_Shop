   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalProject.InfraFinalProject.Infra 5   	   A%clr-namespace:FinalProject.ViewModelsFinalProject.ViewModels 5   	   $   FinalProject.Views.BagInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6	Converter clr-namespace:FinalProject.Infra     5   	   7local%clr-namespace:FinalProject.ViewModels     5   	     � Title$  BagInfoView��5
   	   $	��450��6   $	��800��6*    � SizeToContent$ WidthAndHeight=�66   &   System.Windows.Media.TextOptions   TextRenderingMode$
 Auto=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      . (FinalProject.ViewModels.BagInfoViewModel  5   
   6#    � 	Resources 5      &   FinalProject.Infra.BoolConverter   BoolConverter��%   &	          5   
   6:   5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��5* �6    6.   �� 5      6"   .+�5      �� $��0��5      .+�5      �� -   5        $��image��5       ��5!      �� *CertainBag.Photo+��5"      ��  �� ElementName$ slider��	 �� Path$	 Value���5#      �� $ slider��$	 Value�5$      5%      �� 5&      $��1��6   .+�5'      �� $��1��5(        ChangeSizelbl#���  5)      $��Times New Roman)�5*      $��20(�5+      $��Center=�5,      $��10q�5-      
 �� TextWrapping$

 Wrap=�5.      .��6)   5/      �� 50      -   5        $��slider��51       �� Orientation$ 
Horizontal=�52       � Minimum$	 300Q�53       � Maximum$	 600Q�54      $��15q�55        
FlatSlider#���  56      57      �� 58      ��59      �� $ image��$	 Source�.��6E   5;      5<      5=      � 5>   
   $��1��6    5?      �� 5@      6"   �� 5A      $	��10* �6    6/   .+�5C      � $��0��5D      $��3q�5E      $��Center=�5F      .+�5G      �� $��Times New Roman)�5I      $��20(�5J      $
��Bold"�5K      
����� �
���i��$��3q�5N      $��Center=�5O      ��5H      �� *CertainBag.Title+5P      5Q      �� 5R      $��1��5S      $��
0,0,300,10q�5T      .+�5U      �� $��	0,30,0,30q�5V        Pricelbl#���  5W      $��Times New Roman)�5X      $��20(�5Y      $
��Bold"�5Z      $��Center=�5[      
���  ��
�������5^      �� 5_        Availablelbl#���  5`      $��Times New Roman)�5a      $��20(�5b      $
��Bold"�5c      $��Center=�5d      $��	0,30,0,30q�5e      5f      �� 5g        Manufacturerlbl#���  5h      $��Times New Roman)�5i      $��20(�5j      $
��Bold"�5k      $��Center=�5l      $��	0,30,0,30q�5m      5n      5o      �� 5p      $��1��5q      $��
300,0,0,10q�5r      .+�5s      � $��Center=�6   .+�5t      �� $��	0,30,0,30q�5u      $��Times New Roman)�5w      $��20(�5x      $
��Bold"�5y      $��Center=�5z      
���  ��
���������5v      �� *CertainBag.Price+5}      �� 5~      $��Times New Roman)�5      $��20(�5�      $
��Bold"�5�      $��Center=�5�       
 USDlbl#���  5�      $��	0,30,0,30q�5�      
���  ��
�������5�      5�      � 5�      $��Center=�6   .+�5�      �� $��Times New Roman)�5�      $��20(�5�      $
��Bold"�5�      $��Center=�5�      $��	0,30,0,30q�5�      ��5�      �� *CertainBag.Available+ �� 	Converter# [  5�      5�      � 5�      $��Center=�6   .+�5�      �� $��Times New Roman)�5�      $��20(�5�      $
��Bold"�5�      $��Center=�5�      $��	0,30,0,30q�5�      ��5�      �� **(CertainBag.Manufacturer.ManufacturerName+5�      5�      5�      5�      5�      5�      