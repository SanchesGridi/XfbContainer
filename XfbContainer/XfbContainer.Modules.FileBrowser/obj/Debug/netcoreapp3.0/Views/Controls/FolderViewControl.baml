   M S B A M L   `   `   `  ����[  WXfbContainer.Modules.FileBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:XfbContainer.Modules.FileBrowser.Views.Controls/XfbContainer.Modules.FileBrowser.Views.Controls  5      G    AXfbContainer.Modules.FileBrowser.Views.Controls.FolderViewControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      Lcontrols=clr-namespace:XfbContainer.Modules.FileBrowser.Views.Controls  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  True��5       � 	Resources 5      G   AXfbContainer.Modules.FileBrowser.Views.Controls.FolderItemControl �� 
TargetType   FVC_FolderItemStyle �� Property �� Value  FVC_FolderListBoxStyle  FVC_BorderStyle  FVC_TextBlockStyle  FVC_ButtonStyle��%�  &	        &	 �    &	 j   &	 \   &	 �   �� 5   
   "  6   �5      �� 5       � ��$ 10q�6+   �� 5       � ��$ Center=�68   �� 5       � ��$ Center=�66   5      �� 5   
   " ��5      �5      �� 5       � �� 6/   �� �� 5       � ��$	 1.5q�6+   �� 5       �@��SelectionMode$ Single=�62   �� 5       �@%�IsVirtualizing$
 True��6E   �� 5        �@%�VirtualizationMode$ 	Recycling=�6I   �� 5!       � ��$
 Auto=�6M   �� 5"       � ��$ Disabled=�6O   �� 5#       � �� 5$      �� 5%      .R�5&      � 5'      5)      5+      �� 5.   
   " ��6   �51      �� 52       � ��$	 1.5q�6+   �� 53       �@��Padding$	 1.5q�6,   �� 54       � ��$	 1.5q�64   �� 55       � ��
 �""��60   �� 56       � �� �#0106/   58      �� 5;   
   " ��6   �5>      �� 5?       � ��$	 1.5q�6+   �� 5@       �@��Padding$	 0.5q�6,   �� 5A       � ��$ 10(�6-   �� 5B       � ��
 �""��6/   �� 5C       � ��$
 Left=�68   �� 5D       � ��$ Center=�66   �� 5E       � ��$ WrapWithOverflow=�61   5G      �� 5J   
   " ��6   �5M      �� 5N       � ��$	 100��6-   �� 5O       � ��
 �   �6/   �� 5P       � ��
 �""��6/   �� 5Q       � ��$ Center=�66   �� 5R       � ��$ Right=�68   5T      5V      .��5W      � $	��2.5q�6    � RowDefinitions 5X   
   �� 5Y      �� 5Z      $
��0.2* �6   +�5\   
   �� 5]      -   5         ��Name$ Folder_View_ListBox��5^      $��0��5]      #��[ 5_      ��5`      �� 5a      .R�5b      �� ��5c        5d   "   #��[  6=   5f      5g      5i      �� 5j      $��1��6   #��[ 5k      ._�5l      �  5m      �� 5n      �� 5o      �� 5p      $
��1.2* �6(   �� 5q      $
��1.2* �6(   +�5s      �� 5t      $��0��6$   #��[ 5u   $   
�5v      �� 5w   "   $�Selected folder path: ��6&    �� 5x   "   
��� E���5y   &   ��  �� Path$ DirectoryModel.FullName� �� Mode$ OneWay=�5{      �� 5|      $��1��6$   #��[ 5}   $   
�5~      �� 5   "   $�Selected folder name: ��6&    �� 5�   "   
��� E���5�   &   �� $ DirectoryModel.Name�$ OneWay=�5�      � 5�      $��2��6   	 � ColumnDefinitions	 5�      �� 5�   "   �� 5�   "   +�5�      �� 5�   "   $��0��6,   #��[ 5�   ,   
�5�   &   �� 5�   *   $�Selected folder files: ��6.    �� 5�   *   
��� E���5�   .   �� $ SelectedFolderFilesCount�$ OneWay=�5�   #   �� 5�   "   $��1��6)   $��Compute size��5�   )   #��[ 5�   )   ��5�   )   �� *ComputeFolderSizeCommand+5�      � 5�      $��3��6   	 5�      �� 5�   "   �� 5�   "   +�5�      �� 5�   "   $��0��6,   #��[ 5�   ,   
�5�   &   �� 5�   *   2  ,System.Windows.Markup.XmlAttributeProperties
  XmlSpace
 preserve5�   .   $�Selected folder  dirs: �� �� 5�   *   
��� E���5�   .   �� $$ SelectedFolderDirectoriesCount�$ OneWay=�5�   #   �� 5�   "   $��1��6)   $��Compute size [R]��5�   )   #��[ 5�   )   ��5�   )   �� *#!ComputeFolderSizeRecursiveCommand+5�      5�      5�      5�      5�      