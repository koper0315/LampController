   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   I ELampController, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LampControllerLampController 5   	      LampController.MainWindow   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LampController     5   	   -   5        (   "MahApps.Metro.Controls.MetroWindow    	TitleCaps  .   � Title$ Lamp Controller��5
   	   $	��350��6!   $	��380��6.    � 	Resources 5       �� 
TargetType �� BasedOn �� Property �� Value��%  '��       7��'�� �     �� 5   
   DefaultButtonStyle��" ��6,   8   .�5      ��  � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       � |� .  6*   5      �� 5    
   " ��6   .�5!      ��  � ��$ -1q�6'   5"      5%      .��5'      � #��� ��6   $��0,0,3.6,-0.2q�6R    � ColumnDefinitions 5(   
   �� 5)      $
��347* �6   �� 5*      $	��27* �6   .+�5,   
   �� -   5         ��Name$ label_ports��5,      $��Ports:��6%   $
��Left=�66   $	��Top=�6Q   	 J� RenderTransformOrigin$	 2.865,4.086&�6i   $��	10,10,0,0q�6�   �� 5-   
   -   5        
 ��Name$
 listBox_ports��5-      $
��Left=�6)   $	��101��6D   $	��Top=�6Q   $��84��6i   $��	71,10,0,0q�6t   �� 5.   
   -   5        $
 listBox_logs��5.      $
��Left=�6(   $	��196��6C   $	��Top=�6P   $	��145��6h   $��
10,116,0,0q�6t   �� 5/   
   -   5         ��Name$ button_refresh��5/      $	��⟳��6)   $
��Left=�65   $��15(�6P   $��	10,36,0,0q�6^   $	��Top=�6q   $��46��6�   $��39��6�   6�   �� 50   
   -   5        $ button_select��50      $��Select��6(   $
��Left=�69   $��	10,80,0,0q�6T   $	��Top=�6g   $��46��6   6�   �� 51   
   -   5        $ button_sector_1��51      $��1��6*   $
��Left=�66   $��15(�6Q   $��
240,10,0,0q�6_   $	��Top=�6s   $��50��6�   $��50��6�   6�   �� 52   
   -   5        $ button_sector_2��52      $��2��6*   $
��Left=�66   $��15(�6Q   $��
300,70,0,0q�6_   $	��Top=�6s   $��50��6�   $��50��6�   $��2��6�   �� 53   
   -	   5        $ button_sector_3��53      $��3��6*   $
��Left=�66   $��15(�6Q   $��240,130,0,0q�6_   $	��Top=�6t   $��50��6�   $��50��6�   6�   �� 54   
   -
   5        $ button_sector_4��54      $��4��6*   $
��Left=�66   $��15(�6Q   $��
180,70,0,0q�6_   $	��Top=�6s   $��50��6�   $��50��6�   6�   �� 55   
   -   5        $ button_sector_all��55      $��O��6,   $
��Left=�68   $��20(�6S   $��
240,70,0,0q�6a   $	��Top=�6u   $��50��6�   $��50��6�   6�   �� 56   
   -   5        $ button_mode_norm��56      $��N��6+   $
��Left=�67   $��20(�6R   $��180,251,0,0q�6`   $	��Top=�6u   $��50��6�   $��50��6�   $	 -0.248,1.272&�6�   6�   �� 57   
   -   5        $ button_mode_infra��57      $��I��6,   $
��Left=�68   $��20(�6S   $��180,201,0,0q�6a   $	��Top=�6v   $��50��6�   $��50��6�   6�   �� 58   
   -   5        $ button_reset��58      $��R��6'   $
��Left=�63   $��20(�6N   $��300,251,0,0q�6\   $	��Top=�6q   $��50��6�   $��50��6�   $��2��6�   59      5:      