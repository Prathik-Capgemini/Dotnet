   M S B A M L   `   `   `  ����b  ^Capgemini.PolicyEndorsement.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Capgemini.PolicyEndorsement.Application'Capgemini.PolicyEndorsement.Application  5   	   9    3Capgemini.PolicyEndorsement.Application.AddCustomer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Capgemini.PolicyEndorsement.Application     5   	     � Title$  AddCustomer��5   	   $��Arial)�6   $��502.444��60   $��719.763��6A   .��5	      �� -   5        $��	0,10,2,-5q�5	   @   .@�5
   
   �� $��Add Customer��6   .��5      � -   5        $��grdCUS��5   *   
�������$��10,2,-16,-2q�68    � ColumnDefinitions 5      �� 5      $	��44* �6'   �� 5      $
��105* �6'   �� 5      $
��315* �6'   .+�5      �� $��Customer Name :��6   
���P��$
��Left=�6E   $��	30,30,0,0q�6`   $	��Top=�6s   $
��Bold"�6�   $��2��6�   �� 5      $��Address       :��6   
���P��$
��Left=�6E   $��	30,84,0,0q�6`   $	��Top=�6s   $
��Bold"�6�   $��2��6�   �� 5      $��Telephone     :��6   
���P��$
��Left=�6G   $��
30,134,0,0q�6b   $	��Top=�6v   $
��Bold"�6�   $��2��6�   �� 5      $��Gender        :��6   
���P��$
��Left=�6E   $��
30,187,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��2��6�   �� 5      $��Date of Birth :��6   
���P��$
��Left=�6E   $��
30,242,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��2��6�   �� 5      $��Smoker        :��6   
���P��$
��Left=�6E   $��
30,303,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��2��6�   �� 5      $��Hobbies       :��6   
���P��$
��Left=�6E   $��
30,362,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��2��6�   �� 5      -   5        $��txtCustomerName��5      $
��Left=�61   $��23��6L   $��	21,34,0,0q�6X    �� TextWrapping$
 Wrap=�6k   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5      -   5        $��
txtAddress��5      $
��Left=�6,   $��23��6G   $��	21,84,0,0q�6S   $
 Wrap=�6f   $	��Top=�6{   $	��120��6�   $��2��6�   �� 5      -   5        $��txtTelephone��5      $
��Left=�6.   $��23��6I   $��
21,134,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��2��6�   	� 5      -   5        $��	rdGenderM��5       	� 	GroupName$ rdGender��6/   $
��Male��6D   $
��Left=�6T   $��
21,193,0,0q�6o   $	��Top=�6�   $��2��6�   	� 5      -   5        $��	rdGenderF��5      $ rdGender��6/   $��Female��6D   $
��Left=�6U   $��
94,193,0,0q�6p   $	��Top=�6�   $��2��6�   	� 5      -   5        $��	rdSmokerY��5      $ rdSmoker��6/   $	��Yes��6D   $
��Left=�6R   $��
21,303,0,0q�6m   $	��Top=�6�   $��2��6�   	� 5       -	   5        $��	rdSmokerN��5       $ rdSmoker��6/   $��No��6D   $
��Left=�6Q   $��
94,303,0,0q�6l   $	��Top=�6�   $��2��6�   �� 5!      -
   5        $��
txtHobbies��5!      $
��Left=�6,   $��23��6G   $��
21,362,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5"      -   5        $��dpDob��5"      $
��Left=�6*   $��
21,242,0,0q�6E   $	��Top=�6Y   $	��120��6q   $��2��6}   �� 5#      -   5        $��	btnSubmit��5#      $��Submit��6*   $
��Left=�6;   $��
64,407,0,0q�6V   $	��Top=�6j   $��75��6�   $��2��6�   $��1��6�   �� 5$      -   5        $��btnClear��5$      $��Clear��6)   $
��Left=�69   $��65.694,407,0,0q�6T   $	��Top=�6l   $��75��6�   $��2��6�   5&      5'      �� 5(   
   $��View Customer Info ��6   
�������.��5*      &   System.Windows.Controls.DataGrid  -   5        $��
dgCustomer��5*      $��
10,33,6,68q�6)   5,      5-      5.      5/      