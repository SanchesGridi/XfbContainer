   M S B A M L   `   `   `  ����[  WXfbContainer.Modules.FileBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null{Bclr-namespace:XfbContainer.Modules.FileBrowser.ViewModels.Controls4XfbContainer.Modules.FileBrowser.ViewModels.Controls  5      G    AXfbContainer.Modules.FileBrowser.Views.Controls.FolderItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      QvmBclr-namespace:XfbContainer.Modules.FileBrowser.ViewModels.Controls     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      $	��2.5q�5	      $	��120��5
      $	��120��5      $	��115��5      $	��115��5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$  False��5       � 	Resources 5       �� 
TargetType   FIC_ImageStyle �� Property �� Value  FIC_TextBlockStyle��%@  &	       &	 &   �� 5   
   " ��6   �5      �� 5       � ��$ 1q�6+   �� 5       � ��$ 40��6.   �� 5       � ��$ 40��6-   �� 5       � ��$ Center=�66   �� 5       � ��$
 Left=�68   �� 5       �@��BitmapScalingMode$ HighQuality=�6D   5      �� 5!   
   " ��6   �5$      �� 5%       �@��TextAlignment$
 Left=�62   �� 5&       � ��$ Center=�66   �� 5'       � ��$
 Left=�68   �� 5(       � ��$ WrapWithOverflow=�61   �� 5)       � ��$ 10(�6-   5+      5-      .��5.      �� $
��1.25q�6   
���""��._�50   
   � ��51      �� 52       �� Color 6"   ��  �� Path$5 /(vm:FolderItemControlViewModel.BackgroundColor)� �� Mode$ OneWay=� � RowDefinitions 54      �� 55      �� 56      +�58      �� 59      $��0��6   #��[  5:      ��5;      �� $1 +(vm:FolderItemControlViewModel.ImageSource)�$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�� 5<      $��1��6    5=      �� 5>      $
��2.5* �6(   �� 5?      �� 5@      +�5B      �� 5C      $��0��6'   $
��Auto=�5D   '   $��Disabled=�5E   '   .��5F      �� 
���2�2�#��[ 5G   (   ��5H   (   �� $* $(vm:FolderItemControlViewModel.Name)�$ OneWay=�5I      �� 5J      $��1��6$   
���""��#��[ 5L   $   ��5M   $   �� 
 �� StringFormat$
 Extension: {0}��$/ )(vm:FolderItemControlViewModel.Extension)�$ OneWay=� �� TargetNullValue Z� �� 5P      $��2��6$   
��� E��#��[ 5R   $   ��5S   $   �� $
 
Bytes: {0}��$1 +(vm:FolderItemControlViewModel.BytesLength)�$ OneWay=� Z� 5W      5Y      5Z      5[      