   M S B A M L   `   `   `  ����$   XfbContainer.Modules.FileBrowserC    =XfbContainer.Modules.FileBrowser.Views.Controls.DialogControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      S OPrism.Wpf, Version=7.2.0.1367, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5         DC_WindowStyle#  Prism.Services.Dialogs.Dialog    WindowStyle#  �   5      
���   �$	��170��5      $	��325��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 True��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value  DC_TextBlockStyle  DC_CheckBoxStyle  DC_ButtonStyle��%O  &	       &	    &	 ,   &	 �   �� 5   
   " �6   �5      �� 5       �@ WindowStartupLocation$ CenterOwner=�6G   �� 5       �@�
ResizeMode$ NoResize=�6/   �� 5       �@�ShowInTaskbar$ False��62   �� 5       �@�SizeToContent$ WidthAndHeight=�62   5      �� 5   
   " ��6   �5      �� 5       � ��$	 100��6-   �� 5       � ��$ 30��6.   �� 5       � ��$ Center=�68   �� 5       � ��$ Center=�66   �� 5       � ��$
 Wrap=�61   �� 5       � ��
 �""��6/   5       �� 5!   
   " ��6   �5$      �� 5%       � ��
 �""��6/   �� 5&       � ��$ Center=�68   �� 5'       � ��$ Center=�66   5)      �� 5*   
   " ��6   �5-      �� 5.       � ��
 �   �6/   �� 5/       � ��
 �""��6/   �� 50       � ��
 �""��60   �� 51       � ��$ Center=�66   �� 52       � ��$ 10q�6+   �� 53       � ��$ 5q�6,   �� 54       � ��$ 15��6.   �� 55       � ��$ 75��6-   57      58      .��59      �  � RowDefinitions 5:   
   �� 5;      $
��1.5* �6   �� 5<      �� 5=      +�5?   
   �� 5@      $��0��6   #��[ 5A      ��5B      �� *	Message+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5C      $��1��6   $!��Dont show again this dialog��5D      #��[ 5E      	 d� 	IsChecked	 5F      �� *DontShowAgain+$ TwoWay=�$ PropertyChanged=�� 5G      $��2��6   
 � ColumnDefinitions
 5H      �� 5I      �� 5J      +�5L      �� 5M      $��0��6   $��Ok��5N      $
��Left=�5O       �� 	IsDefault$
 True��5P      $
��true��5Q      #��[ 5R      ��5S      �� *CloseDialogCommand+�� 5T      $��2��6   $��Cancel��5U      $��Right=�5V       �� IsCancel$
 True��5W      $��false��5X      #��[ 5Y      ��5Z      �� *CloseDialogCommand+5\      5^      5_      