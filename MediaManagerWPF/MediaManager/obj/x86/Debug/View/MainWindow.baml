   M S B A M L   `   `   `  ����G  CMediaManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MediaManager.ConvertersMediaManager.Converters  5   	   =#clr-namespace:MediaManager.ControlsMediaManager.Controls  5   	   B >WatTmdb, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null8)clr-namespace:WatTmdb.V3;assembly=WatTmdb
WatTmdb.V3 5	   	   ?$clr-namespace:MediaManager.ViewModelMediaManager.ViewModel  6>   U QMahApps.Metro, Version=0.14.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      +clr-namespace:MediaManagerMediaManager  5          MediaManager.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6conv%clr-namespace:MediaManager.Converters     5   	   8controls#clr-namespace:MediaManager.Controls     5   	   8v3)clr-namespace:WatTmdb.V3;assembly=WatTmdb     5	   	   :	viewModel$clr-namespace:MediaManager.ViewModel     6>   Q	controls1;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5
   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      3mediaManagerclr-namespace:MediaManager     5      (  "MahApps.Metro.Controls.MetroWindow    ShowCloseButton  .    ShowMaxRestoreButton .     ShowMinButton .   � Title$ Media Manager��5       � WindowState$ 	Maximized=�6.    � Icon$9 3/MediaManager;component/Images/osa_server_media.png��6F    � 	Resources 5      /   )MediaManager.ViewModel.MovieInfoViewModel   MovieInfoViewModel3   -MediaManager.Converters.ActorToImageConverter  ActorToImageConverter   BooleanToVisibilityConverter �� 
StartPoint �� EndPoint  BoxBackground	 �� Opacity
 � Offset � Color��%H  &	        &	      &	 &     &	 9       5   
   6'     5   
   6%   �� 5   
   6'   �� 5   
   $	 0,0&�6   $	 0,1&�6/   $		 0.8Q�6T   .��5      � � 5      $
 0Q�6   $ Black��6*   � 5      $	
 0.3Q�6   $ Black��6,   � 5      $
 1Q�6   $ DarkGray��6*   5      5      5         RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   5*      .��5-      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5.   
   �� 5/      $
��Auto �6   �� 50      $��* �6   .+�53   
   � $��0��6   $��Right=�6    K� ZIndex$	 100��68   $��	0,15,15,0q�6E    � ColumnDefinitions 54      �� 55      $
��Auto �6#   �� 56      $��* �6#   .+�58      ]� $��1��6   $��30��6�   $��30��6�   $
��Left=�6�   $��5,0,5,0q�6�   y�6(   �� *	IsLoading+ �� 	Converter# [ .+�59      ,   &MediaManager.Controls.LoadingAnimation  z�5:      �� 5;       �� ScaleX$
 0.35Q�6)    �� ScaleY$
 0.35Q�67   5=      5>      �� 5@       �� Orientation$ 
Horizontal=�6   $��0��62   $��Center=�6B   $��5q�6_   .+�5A      �� -   5        $	��260��5A   ^   $��Roboto)�6j   $��20(�6~   $��5,0,5,0q�6�    J� Opacity$	 0.6Q�6�   ��6   �� *MovieToSearch+ �� UpdateSourceTrigger$ PropertyChanged=�   MediaManager.MainWindow   TextBoxPressEnterCommand 5B      �� *SearchMovieCommand+6j   �� 5C      $��Search��6   $��70��6Q   $��Roboto)�6\   $��14(�6p   $	 0.6Q�6~   ��6*   �� *SearchMovieCommand+6~   �� 5D      $��10,0,0,0q�6   $	��120��6-   $��Roboto)�5E      $��Center=�6/   $��14(�6Q   $	 0.6Q�5F   t   ��5D   9   �� *MovieResults+ �� SelectedItem 6^   �� *SelectedMovie+y�5F      �� *
IsLoaded+# [ ��5G      �� 5H       �� DataType$ v3:MovieResult��6'   .R�5I      �� $��Center=�6H   $��Roboto)�6c   $��13(�6w   ��6(   �� *original_title+6w   5J      5L      5M      5N      � 5P   
   -   5        $��MainGrid��5P   -   $��0��6   $��2��6   $ 99��6=   .+�5Q      �  5R      �� 5S      $
��3.5* �6$   �� 5T      $��* �6$   .+�5V      �� #��[ 6   $��1q�6E   
���   � �� CornerRadius$ 15��6m   $��10q�6   y�6�   �� *InfoVisibility+._�5W      � $��Stretch=�6   $��Stretch=�67   $��5q�6U    5X      �� 5Y      $
��Auto �6/   �� 5Z      .+�5\      � $��0��6   .+�5]      �� $ Vertical=�6)   $	��Top=�6@   $��Stretch=�6X   
������ y�6�   �� *
IsLoaded+# [ .+�5^   "   �� $ 	10,10,0,0��6)   ._�5_   &   �� $��Uniform=�6,   $	��300��6X   ��6>   �� *Poster+6X   5`   #   �� 5a   "   $ 	0,0,10,10��6)   ._�5b   &   �� $
��Fill=�6,   $
 0.75Q�6U   $	��300��6d   $	��200��6p   ��6;   �� *Poster+ � LayoutTransform 5c   *   V� 5d   .   .~�5e   2   �� $ -1Q�6A   5f   /    J� OpacityMask 5h   *   �� 5i   .   $ 0.5,0.0&�6B   $ 0.5,1.0&�6W   .��5j   2   � $	
 0.0Q�6?   $ 	#00000000��6L   � 5k   2   $	
 1.0Q�6?   $ 	#FF000000��6L   5l   /   5n   '   5o   #   5p      5q      � 5s      $	��Top=�6   $��Stretch=�67   $��1��6U    5t      �� 5u   "   $
��Auto �60   �� 5v   "   $
��Auto �60   �� 5w   "   $
��Auto �60   �� 5x   "   $
��Auto �60   �� 5y   "   $
��Auto �60   �� 5z   "   $
��Auto �60   �� 5{   "   $��* �60   .+�5}      �� $ 
Horizontal=�6)   $��0��6B   .+�5~   "   ��   HeaderTextStyle#��[ 6,   $��	10,10,5,0q�6k   $��Bottom=�6~   ��6U   �� *Name+6~   �� 5   "     RegularTextStyle#��[ 6,   $��	5,10,10,4q�6l   $��Bottom=�6   ��6V   �� *Year+6   �� 5�   "   #��[ 6,   $��	5,10,10,4q�6r   $��Bottom=�6�   ��6V   �� *
MovieGenre+6�   5�      �� 5�        SmallHeaderTextStyle#��[ 6(   $��1��6V   $��Italic$�6c   $��	10,5,10,0q�6�   $��Center=�6�   ��6v   �� *	Tagline+6�   �� 5�      $ 
Horizontal=�6)   $��2��6B   .+�5�   "   �� #��[ 6,   $��	10,5,10,0q�6r   $��Center=�6�   ��6Z   �� *Rating+6�   �� 5�   "   #��[ 6,   $��	10,5,10,0q�6w   $��Center=�6�   ��6Z   �� *RuntimeText+6�   �� 5�   "   #��[ 6,   $��	10,5,10,0q�6w   $��Center=�6�   ��6Z   �� *RevenueText+6�   5�      �� 5�      #��[ 6(   $��3��6R   $��
10,20,10,0q�6   ��6_   �� *SynopsisHeader+6   �� 5�      $
��Auto=�6+   $��Disabled=�6N   $��4��6w   .��5�   "   �� #��[ 6,   $
��Wrap=�6p   $��	10,5,10,0q�6�   ��6V   �� *
Synopsis+6�   5�      �� 5�      #��[ 6(   $��
10,20,10,0q�6n   $��5��6�   ��6R   �� *
CastHeader+6�   � 5�      $��6��6#   .+�5�   "   �� $
��Auto=�6/   $
��Auto=�6R   .��5�   &   �� $��Stretch=�6W   $��	10,5,10,0q�6s   ��63   �� *CastMembers+��5�   *   �� 5�   .   $ v3:Cast��6;   .R�5�   2   �� $ 
Horizontal=�6=   .+�5�   6   �� $��40��6�   $��UniformToFill=�6�   $ 1Q�6�   $
��10,5q�6�   ��6<   �� *profile_path+# [ 6�   �� 5�   6   #��[ 6V   $��Regular"�6�   $��Center=�6�   ��6@   �� *name+6�   �� 5�   6   $
�� as ��6@   #��[ 6L   $��Center=�6v   �� 5�   6   #��[ 6[   $��Italic$�6�   $��Center=�6�   ��6@   �� *	character+6�   5�   3   5�   /   ��5�   *   �� 5�   .   .R�5�   2   A�  A� Columns$ 3��6>   5�   /   5�   '   5�   #   5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $��* �6+   �� 5�      $��4* �6+   .+�5�      �� $��0��6   #��[ 6-   
���   �$��1q�6m   $ 15��6�   $��Stretch=�6�   $��Stretch=�6�   $	 0.8Q�6�   $��10q�6�   y�6�   �� *TrailerVisibility+._�5�      � $��5q�6   .+�5�      �  5�   "   �� 5�   &   $
��Auto �64   �� 5�   &   $��* �64   .+�5�   "   �� #��[ 6,   $��0��6U   $��Trailer��6b   $��	10,10,5,0q�6q   )   #MediaManager.Controls.YouTubeViewer  5�   "   $��1��69   $��Stretch=�6g   $��Stretch=�6�      Source 6F   �� *TrailerSource+6�   5�      5�      5�      �� 5�      $��1��6   #��[ 6-   
���   �$��1q�6m   $ 15��6�   $��Stretch=�6�   $��Stretch=�6�   $	 0.8Q�6�   $��10q�6�   y�6�   �� *TrailerVisibility+._�5�      � $��5q�6   .+�5�      �  5�   "   �� 5�   &   $
��Auto �64   �� 5�   &   $��* �64   .+�5�   "   �� #��[ 6,   $��0��6U   $��Similar Movies��6b   $��	10,10,5,0q�6x   �� 5�   "   $��1��6/   .��5�   &   �� ��6/   �� *SimilarMoviesCollection+��5�   *   �� 5�   .   $ viewModel:MovieViewModel��6;   .R�5�   2   *   $MediaManager.Controls.ClickableImage  $��92��6d   $	��138��6o   $
��10,0q�6|   ��6J   �� *Poster+.	  (System.Windows.Interactivity.Interaction  	  Triggers  5�   6   /
  )System.Windows.Interactivity.EventTrigger
  5�   :   ! 
  	EventName$%! MouseLeftButtonDoubleClickEvent��6I   .  (System.Windows.Interactivity.TriggerBase"   Actions." 5�   >   6  0System.Windows.Interactivity.InvokeCommandAction  #   Command# 6T   �� *LoadMovieCommand+5�   ;   5�   3   5�   /   ��5�   *   �� 5�   .   .R�5�   2   �� $ 
Horizontal=�6=   5�   /   5�   '   5�   #   5�      5�      5�      5�      ��5�      �� 5�      $ j� Stretch$$ UniformToFill=�6J   % �� ImageSource% 6!   �� *BackgroundPoster+6J   5�      5�      5�      5�      