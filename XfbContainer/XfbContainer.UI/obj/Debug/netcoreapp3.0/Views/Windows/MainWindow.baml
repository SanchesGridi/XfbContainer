   M S B A M L   `   `   `  ����  XfbContainer.UI.    (XfbContainer.UI.Views.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59N JPrism.DryIoc.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=null&prismhttp://prismlibrary.com/   5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Xfb Container��5   	   ���#111$	��750��5   	   $	��925��5	   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 True��5
   	    � 	Resources 5       �� 
TargetType   MW_MenuItemStyle_External �� Property �� Value  MW_MenuItemStyle_Internal  MW_MenuStyle  MW_MainGridBorderStyle  MW_BorderSpliterStyle  MW_TextBlockStyle��%�  &	       &	 �    &	 =   7   &	 F   &	    &	 �   �� 5   
   " m�6   �5      �� 5       � ��
 �  ��6/   �� 5       � ��
 � E��60   �� 5       � ��$
 0.25q�64   �� 5       � ��$ 15(�6-   5      �� 5   
   " m�6   �5      �� 5       � ��$	 1.5q�6+   �� 5       � ��
 �   �6/   5      �� 5   
   " o�6   �5"      �� 5#       � ��$	 1.5q�6,   �� 5$       � ��$	 2.5q�6+   �� 5%       � ��$	 2.5q�64   �� 5&       � ��
 �""��60   �� 5'       � ��
 �   �6/   �� 5(       � ��8   67   5*      �� 5-   
   " ��6   �50      �� 51       �@��Padding$	 1.5q�6,   �� 52       � ��$	 2.5q�6+   �� 53       � ��
 �""��60   �� 54       � ��$	 2.5q�64   56      �� 57   
   " ��6   �5:      �� 5;       � ��
 �""��6/   �� 5<       � ��$	 2.5��6-   5>      �� 5A   
   " ��6   �5D      �� 5E       � ��$ Center=�68   �� 5F       � ��$ Center=�66   �� 5G       � ��$
 Wrap=�61   �� 5H       �@��TextAlignment$ Center=�62   �� 5I       � ��$ 15(�6-   5K      5M      .��5N      �  � RowDefinitions 5O   
   �� 5P      $
��Auto �6   �� 5Q      +�5S   
   o� 5T      $��0��6   #��[ 5U      .@�5V      m� $��Views��6   .@�5W      m� $��File Browser��6   #��[ 5X       m� Command 5Y      �� *SwitchFileBrowserCommand+5Z      5[      �� 5\      $��1��6   #��[ 5]      ._�5^      � 	 � ColumnDefinitions	 5_      �� 5`      �� 5a      $
��Auto �6+   �� 5b      $��0.45* �6+   +�5d      �� 5e      $��0��6)   !  Prism.Regions.RegionManager
   
RegionName$
 FileBrowserRegion��5f   )   �� 5g      $��1��6!   #��[ 5h   !   �� 5i      $��2��6)   ��5k      �� 5l   "   #��[ 6,   
�5m   &   �� 5n   *   $�File Browser��6.   
���""��5o   .   �� 5p   *   �� 5q   *   $$�Your Module Can Be Placed Here��6.   
���2�2�5r   .   �� 5s   *   �� 5t   *   $�Open For Extension��6.   
��� ���5u   .   5w   #   5y      5{      5|      5~      5      