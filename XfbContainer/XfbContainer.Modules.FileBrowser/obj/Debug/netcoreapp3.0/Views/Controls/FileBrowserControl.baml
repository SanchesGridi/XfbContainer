   M S B A M L   `   `   `  ����$   XfbContainer.Modules.FileBrowserH    BXfbContainer.Modules.FileBrowser.Views.Controls.FileBrowserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  True��5
      $	��2.5q�5      $	��2.5q�5      
���   � � 	Resources 5       �� 
TargetType   FBC_MainGridStyle �� Property �� Value  FBC_OpenFolderBtnStyle ^� HasDropShadow ^� 	Placement �� Triggers P� Property	 P� Value
 �� BitmapScalingMode   FBC_FolderPathTextBlockStyle&   System.Windows.Media.TextOptions  FBC_StrokeBorderStyle��%?  &	       &	 X    &	 �   &	 y   �� 5   
   " �6   �5      �� 5       � �� �#0A11116/   5      �� 5   
   " ��6   �5      �� 5       � �� 5      �� 5      .R�5       �� ��5!   "   �� 5"   &   " ��6,   �5#   *   �� 5$   .    �@�ToolTip 5%   2   _� 5&   6   $��Open Folder��6>   
���   �
���""��
���""��$
 True��5*   >   $ Bottom=�5+   >   5,   7   5.   /   �� 5/   .    � ��$	 1.5q�6G   �� 50   .    �@J�Opacity$
 0.95Q�6H   �� 51   .    � ��$ 30��6J   �� 52   .    �@��CornerRadius$ 5��6M   �� 53   .    � ��$ 2q�6P   �� 54   .    � ��
 �2�2�6K   �� 55   .    � ��
 �""��6L    57   *   P� 58   .    �@J�IsMouseOver$
	 True��6M    �59   2   �� 5:   6    �@J�Opacity$ 1Q�6P   �� 5;   6    � ��
 �/���6S   5=   /   5?   '   ._�5A   "   �� $*��$..\..\Assets\directory_icon_open.png��6(   $
 HighQuality=�5B   (   5C      5D      5F      5H      �� 5K   
   " ��6   �5N      �� 5O       � ��$	 1.5q�6+   �� 5P       � ��
 �""��6/   �� 5Q       � ��$
 Wrap=�61   �� 5R       �@��TextAlignment$ Center=�62   �� 5S       � ��$ 30��6.   �� 5T       � ��$
 11.5(�6-   �� 5U       �@ TextRenderingMode$ 	Grayscale=�6B   �� 5V       �@ TextFormattingMode$ Ideal=�6C   5X      �� 5[   
   " ��6   �5^      �� 5_       � ��
 �""��60   �� 5`       � ��$	 1.5q�64   �� 5a       � ��$	 1.5q�6+   5c      5e      .��5f      � #��[  6    � RowDefinitions 5g   
   �� 5h      $
��0.1* �6   �� 5i      +�5k   
   �� 5l      $��0��6   #��[ 5m      ._�5n      �  � ColumnDefinitions 5o      �� 5p      $
��0.1* �6+   �� 5q      +�5s      �� 5t      $��0��6!   #��[ 5u   !   ��5v   !   �� *OpenFolderCommand+5w      �� 5x      $��1��6$   #��[ 5y   $   
�5z      �� 5{   "   $�Selected Root Path:��6&   �� 5|   "   �� 5}   "   
��� E���5~   &   �� *
FolderPath+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��0.5* �6'   �� 5�      +�5�      �� 5�      $��0��6   #��[ 5�      ._�5�      �� !  Prism.Regions.RegionManager   
RegionName$ FolderTreeRegion��6)   5�      �� 5�      $��1��6   #��[ 5�      ._�5�      �� $ FolderViewRegion��6)   5�      5�      5�      5�      