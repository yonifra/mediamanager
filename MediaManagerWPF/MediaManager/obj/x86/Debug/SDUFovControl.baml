   M S B A M L   `   `   `  ����B  >ButtonX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ButtonXButtonX  5          ButtonX.SDUFovControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )buttonXclr-namespace:ButtonX     5      -   5        $��m_fovControl��5   .   $	��318��5	      $	��349��6     � 	Resources  5
         PointConverter�� 5   
   %   &	        &� 5      6   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $
��None=�6   $'��!/ButtonX;component/Images/map.png��6   $��	-46,0,0,0q�6J   �� 5   
   -   5        $��image1��5      $
��Fill=�6   $B��</ButtonX;component/Images/SDU_Under_control_another_user.ico��6-   $��
0,0,147,88q�6s   $��Right=�6�   $��24��6�   $��24��6�   $��Bottom=�6�   �� 5   
   $	��100��6   $	��100��6   $��109,98,109,2q�6*   z�5      �� 5       �� CenterX$ 50Q�6:    �� CenterY$ 0Q�6G    �� Angle 6"   �� *Angle+6G   .+�5      �� -   5         ��Name$ 
m_beamCone��5   b   $	��100��6   $	��100��6    $	��Top=�6-   $��Center=�6E   ��5      H� 5       H� Drawing 5      � 5       � Geometry 5   "   � 5    &   .��5!   *   B� .��5"   .   E�  E� 
StartPoint$
 50,0&�69   	 E� IsClosed	 . .��5#   2   �� 
 �� Point$
 0,100&�6>   -   5        
m_leftLine��5#   L   �� 5$   2   $
 100,100&�6>   -   5        m_rightLine��5$   N   5%   /   5&   +   5'   '    � Brush 5)   "   �� 5*   &    �� 
StartPoint$	 0,0&�6:    �� EndPoint$	 0,1&�6K    �� Opacity$	 0.5Q�6Z   .��5+   *   � � 5,   .    � Color$ Yellow��6;    � Offset$ 0Q�6J   � 5-   .   $ Transparent��6;   $ 1Q�6O   5.   +   5/   '   51      53      55      56      � 57   
   $��1��6    58      �� 59      $
��Auto �6    �� 5:      �� 5;      $
��Auto �6    �� 5<      .+�5>      ]� $��0��6   .+�5?      �� -   5        $��lblAngle��5?   Y   $��Rotation Angle��6   $��28��61   $
��Left=�6=   $	��Top=�6i   $
��Left=�6�   �� 5@      -   5        $��lblAngleFormatted��5@   p   $��28��6H   $
��Left=�6T   $	��Top=�6�   $
��Left=�6�   ��6   �� *AngleFormatted+ �� Mode$ OneWay=�6�   5A      � 5B      $��1��6    � ColumnDefinitions 5C      �� 5D      �� 5E      $
��Auto �6'   �� 5F      .+�5H      �� -   5        $��btnStepLeft��5H      $��0,0,0,22q�6,   |�.  ��6P   �� *MoveLeftStepCommand+��5I      �� 5J       �� ImageSource$- '/ButtonX;component/Images/leftArrow.png��6%   5L      �� 5M      -	   5        $��rotationAngleSlider��5M   V   $��	10,0,10,0q�6   $��23��6,   $��Center=�68   $	��Top=�6q   $	��249��6�   $��1��6�    � Maximum$	 360Q�6�    � Minimum$ 0Q�6�    �� TickPlacement$ TopLeft=�6�    � Value 6�   �� *Angle+$ TwoWay=�6�   �� 5N      -
   5        $��btnStepRight��5N      $��2��6-   $��0,0,0,24q�6=   |�.  ��6a   �� *MoveRightStepCommand+��5O      �� 5P      $. (/ButtonX;component/Images/rightArrow.png��6%   5R      5S      ]� 5U      $��2��6   .+�5V      �� -   5        $��lblZoom��5V   N   $
��Zoom��6   $��28��6'   $
��Left=�63   $	��Top=�6]   �� 5W      -   5        $��lblZoomFormatted��5W   n   $��28��6G   $
��Left=�6S   $	��Top=�6�   ��6   �� *ZoomFormatted+$ OneWay=�6�   �� 5X      -   5        $��lblFovAngleTitle��5X   S   $��	Fov Angle��6   $��28��6,   $
��Left=�68   $	��Top=�6k   �� 5Y      -   5        $��lblFovXAngle��5Y   s   $��28��6L   $
��Left=�6X   $	��Top=�6�   ��6   �� *	FovXAngle+ �� StringFormat$ {0:F}��6�   5Z      �� 5[      -   5        $��
zoomSlider��5[   >   $��23��6   $��Center=�6!   $	��Top=�6P   $	��249��6h   $��3��6�   $ 1Q�6�   $ 70Q�6�   $ TopLeft=�6�    6u   �� *Zoom+6�   5\      5^      5_      