   M S B A M L   `   `   `  ����B  >Moziwpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MoziwpfMoziwpf  5   	       Moziwpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Moziwpf     5   	     � Title$$  Mozi és műsor nyilvántartó��5   	   $	��350��6,   $	��525��69   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��68* �6   �� 5      $
��449* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Felhasználónév: ��6   $
��Left=�6:   $��	68,84,0,0q�6U   $	��Top=�6h   $��2��6�   �� 5   
   -   5        $ label1��5      $��	Jelszó: ��6    $
��Left=�63   $��19.515,141,0,0q�6N   $	��Top=�6f   $��1��6~   �� 5   
   -   5         ��Name$	 nev��5      $
��Left=�6   $��23��6:   $��163.515,84,0,0q�6F    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5   
   -   5        $ jelszo��5      $
��Left=�6"   $��23��6=   $��163.515,145,0,0q�6I   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   $��1��6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��163.515,202,0,0q�6@   $	��Top=�6Y   $	��120��6q   $��1��6}   .@�5      �� $��Üzemeltető��6   
 � Tag$ 
uzemelteto��60   �� 5      $��
Látogató��6   $ latogato��6.   5      �� 5   
   $��Típusa:��6   $
��Left=�6#   $��19.515,198,0,0q�6>   $	��Top=�6V   $��1��6n   �� 5   
   -   5         ��Name$ regisztracio��5      $��Regisztráció��6'   $
��Left=�6>   $��65.515,265,0,0q�6Y   $	��Top=�6q   $��75��6�   $��1��6�   6�   �� 5   
   -   5        $ belepes��5      $��	Belépés��6"   $
��Left=�64   $��192.515,265,0,0q�6O   $	��Top=�6h   $��75��6�   $��1��6�   6�   5      5      