   M S B A M L   `   `   `  ����M  ISihle_POE_18012731, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sihle_POE_18012731Sihle_POE_18012731  5   	   %    Sihle_POE_18012731.RentProperty   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sihle_POE_18012731     5   	     � Title$  RentProperty��5   	   $	��450��6   $
��1000��6+   .��5	      � .+�5
   
   �� $&�� Hello There Welcome To Renting  ��6   $��
250,20,0,0q�6;   6Q   �� 5   
   $!��Enter the following values.��6   $��	10,50,0,0q�66   6K   � 5   
   $��	30,90,0,0q�6    � ColumnDefinitions 5      �� 5      $	��230 �6#   �� 5      $	��100 �6#   �� 5      $��10 �6#   �� 5      $��10 �6#    � RowDefinitions 5      �� 5      $��25 �6    �� 5      $��22 �6    �� 5      $��25 �6    �� 5      $��22 �6    �� 5      $��25 �6    �� 5      $��22 �6    .+�5       �� $��0��6   $��0��6&   $$��Please enter your monthly rent��67   $��25��6]   $	��Top=�6j   �� 5!      -   5         ��Name$ txtRent��5!   6   $��1��6   $��0��6%   $	��Top=�6G   5"      � 5#   
   $��
50,120,0,0q�6   .+�5$      �� -   5         ��Name$ 	btnSubmit��5$   -   $��Submit Rent��6@   $
��Left=�6V   $��30��6q   $��-15,25,0,-100q�6}   $	��Top=�6�   $	��200��6�   �� 5%      -   5         ��Name$ Notify��5%      $��Total Of Expenses:=��6$   $
��Left=�6B   $��30��6]   $��0,80,0,-100q�6i   $	��Top=�6~   5&      � 5(   
   $��320,80,-10,0q�6   .+�5)      �� $
��Left=�6   $	��Top=�60   
���   �$��2q�6\   ._�5*      � -   5        $��grid1��5*   R   $	��300��6   $
��Left=�6$   $��	12,12,0,0q�6?   $	��Top=�6_   $	��479��6w   ���	#FFF2F2F26�   5+      �� 5,      $*��$Please choose to Purchase Car Or Not��6   $
��Left=�6C   $	��Top=�6^   	� 5-      -   5         	�Name$ rdbyes��5-   B   $��	40,30,0,0q�6/   $��(1) Yes��6R   $
��Left=�6d   $	��Top=�6   	� 5.      -   5        $ rdbno��5.   A   $��	40,55,0,0q�6.   $��(2) No��6P   $
��Left=�6a   $	��Top=�6|   �� 5/      -   5        $ quitApplication��5/   N   $��Quit Application��63   $��
10,280,0,0q�6g   $
��Left=�6{   $	��Top=�6�   $	��175��6�   �� 50      -   5        $
 back��50   B   $��Back To Expense��6(   $��250,280,0,0q�6Q   $
��Left=�6f   $	��Top=�6�   $	��175��6�   � 52      $��	10,75,0,0q�6   .+�54      �� $��Report��6   $
��Left=�6)   $	��Top=�6D   �� 55      -	   5         ��Name$ rctVehicleReport��55      $��	15,30,0,0q�68   $
��Left=�6K   $	��150��6f   $	��Top=�6s   $	��459��6�   57      58      59      5:      5<      