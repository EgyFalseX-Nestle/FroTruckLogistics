;#DropDB FroTruckLogisticsEasyTest

#Application FroTruckLogisticsWin
#Application FroTruckLogisticsWeb
#IfDef FroTruckLogisticsWin

*Action About...
 
*Action OK

#EndIf

#IfDef FroTruckLogisticsWeb
*Action Navigation(My Details)
#EndIf
