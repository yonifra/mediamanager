   M S B A M L   `   `   `  ���� G  CMediaManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MediaManager.ConvertersMediaManager.Converters  =#clr-namespace:MediaManager.ControlsMediaManager.Controls  B >WatTmdb, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null8)clr-namespace:WatTmdb.V3;assembly=WatTmdb
WatTmdb.V3 ?$clr-namespace:MediaManager.ViewModelMediaManager.ViewModel  U QMahApps.Metro, Version=0.14.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity     MediaManager.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6conv%clr-namespace:MediaManager.Converters     8controls#clr-namespace:MediaManager.Controls     8v3)clr-namespace:WatTmdb.V3;assembly=WatTmdb     :	viewModel$clr-namespace:MediaManager.ViewModel     Q	controls1;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     (  "MahApps.Metro.Controls.MetroWindow    ShowCloseButton  .    ShowMaxRestoreButton .     ShowMinButton .   � Title$ Media Manager�� � WindowState$ 	Maximized=� � Icon$9 3/MediaManager;component/Images/osa_server_media.png�� � 	Resources /   )MediaManager.ViewModel.MovieInfoViewModel   MovieInfoViewModel3   -MediaManager.Converters.ActorToImageConverter  ActorToImageConverter   booleanToVisibilityConverter �� 
StartPoint �� EndPoint  BoxBackground	 �� Opacity
 � Offset � Color��%�   &	        &	      &	 
     &	          �� �� $	 0,0&�$	 0,1&�$		 0.8Q�.��� � $
 0Q�$ Black��� $	
 0.3Q�$ Black��� $
 1Q�$ DarkGray��   RightWindowCommands +  %MahApps.Metro.Controls.WindowCommands  .���  � DataContext ��  �� Source# [   � RowDefinitions �� $
��Auto ��� $��* �.+�� $��0��$��Right=� K� ZIndex$	 100��$��	0,15,15,0q� � ColumnDefinitions �� $
��Auto ��� $��* �.+�]� $��1��$��30��$��30��$
��Left=�$��5,0,5,0q�y��� *	IsLoading+ �� 	Converter# [ .+�,   &MediaManager.Controls.LoadingAnimation  z���  �� ScaleX$
 0.35Q� �� ScaleY$
 0.35Q���  �� Orientation$ 
Horizontal=�$��0��$��Center=�$��5q�.+��� $	��260��$��Roboto)�$��20(�$��5,0,5,0q� J� Opacity$	 0.6Q����� *MovieToSearch+�� $��Search��$��70��$��Roboto)�$��14(�$	 0.6Q�����  �� Path$ SearchMovieCommand��� $��10,0,0,0q�$	��120��$��Roboto)�$��Center=�$��14(�$	 0.6Q����� *MovieResults+ �� SelectedItem �� *SelectedMovie+y��� *
IsLoaded+# [ ����  �� DataType$ v3:MovieResult��.R��� $��Center=�$��Roboto)�$��13(����� *original_title+� -   $��MainGrid��$��0��$��2��$ 99��.+��  �� $
��3.5* ��� $��* �.+��� #��[ $��1q�
���   � �� CornerRadius$ 15��$��10q�y��� *InfoVisibility+._�� $��Stretch=�$
��Left=�$��5q� �� $
��Auto ��� .+�� $��0��.+��� $ Vertical=�$	��Top=�$��Stretch=�
������ y��� *
IsLoaded+# [ .+��� $ 	10,10,0,0��._��� $��Uniform=�$	��300������ *Poster+�� $ 	0,0,10,10��._��� $
��Fill=�$
 0.75Q�$	��300��$	��200������ *Poster+ � LayoutTransform V� .~��� $ -1Q� J� OpacityMask �� $ 0.5,0.0&�$ 0.5,1.0&�.��� $	
 0.0Q�$ 	#00000000��� $	
 1.0Q�$ 	#FF000000��� $	��Top=�$��Stretch=�$��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��0��.+���   HeaderTextStyle#��[ $��	10,10,5,0q�$��Bottom=����� *Name+��   RegularTextStyle#��[ $��	5,10,10,4q�$��Bottom=����� *Year+�� #��[ $��	5,10,10,4q�$��Bottom=����� *
MovieGenre+��   SmallHeaderTextStyle#��[ $��1��$��Italic$�$��	10,5,10,0q�$��Center=����� *	Tagline+�� $ 
Horizontal=�$��2��.+��� #��[ $��	10,5,10,0q�$��Center=����� *Rating+�� #��[ $��	10,5,10,0q�$��Center=����� *RuntimeText+�� #��[ $��	10,5,10,0q�$��Center=����� *RevenueText+�� #��[ $��3��$��
10,20,10,0q����� *SynopsisHeader+�� $
��Auto=�$��Disabled=�$��4��.���� #��[ $
��Wrap=�$��	10,5,10,0q����� *
Synopsis+�� #��[ $��
10,20,10,0q�$��5������ *
CastHeader+� $��6��.+��� $
��Auto=�$
��Auto=�.���� $��Stretch=�$��	10,5,10,0q����� *CastMembers+���� $ v3:Cast��.R��� $ 
Horizontal=�.+��� $��40��$��UniformToFill=�$ 1Q�$
��10,5q����� *profile_path+# [ �� #��[ $��Regular"�$��Center=����� *name+�� $
�� as ��#��[ $��Center=��� #��[ $��Italic$�$��Center=����� *	character+���� .R�A�  A� Columns$ 3��� $��1�� �� $��* ��� $��4* �.+��� $��0��#��[ 
���   �$��1q�$ 15��$��Stretch=�$��Stretch=�$	 0.8Q�$��10q�y��� *TrailerVisibility+._�� $��5q�.+��  �� $
��Auto ��� $��* �.+��� #��[ $��0��$��Trailer��$��	10,10,5,0q�)   #MediaManager.Controls.YouTubeViewer  $��1��$��Stretch=�$��Stretch=�   Source �� *TrailerSource+�� $��1��#��[ 
���   �$��1q�$ 15��$��Stretch=�$��Stretch=�$	 0.8Q�$��10q�y��� *TrailerVisibility+._�� $��5q�.+��  �� $
��Auto ��� $��* �.+��� #��[ $��0��$��Similar Movies��$��	10,10,5,0q��� $��1��.���� ���� *SimilarMoviesCollection+���� $ viewModel:MovieViewModel��.R�*   $MediaManager.Controls.ClickableImage  $��92��$	��138��$
��10,0q����� *Poster+.  (System.Windows.Interactivity.Interaction   Triggers /	  )System.Windows.Interactivity.EventTrigger	    	  	EventName$%  MouseLeftButtonDoubleClickEvent��.
  (System.Windows.Interactivity.TriggerBase! 
  Actions.! 6  0System.Windows.Interactivity.InvokeCommandAction  "   Command" �� *LoadMovieCommand+���� .R��� $ 
Horizontal=����� # j� Stretch$# UniformToFill=�$ �� ImageSource$ �� *BackgroundPoster+