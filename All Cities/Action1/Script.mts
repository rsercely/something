fromCitiesList = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").GetROProperty("all items")
citylist = split(fromCitiesList,vbcr)

For fromCity = 1 To len(citylist)
	WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").Select fromCity
	toCitiesList = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").GetROProperty("all items")
	toCities = split(toCitiesList,vbcr)
	For toCity = 1 To len(toCities)
		If fromCity != toCity  Then
			
		End If
		WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").Select toCity @@ hightlight id_;_2058267672_;_script infofile_;_ZIP::ssf7.xml_;_

WpfWindow("Micro Focus MyFlight Sample").WpfCalendar("datePicker").SetDate "22-Aug-2020" @@ hightlight id_;_2058268008_;_script infofile_;_ZIP::ssf9.xml_;_
WpfWindow("Micro Focus MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_2058203544_;_script infofile_;_ZIP::ssf10.xml_;_
WpfWindow("Micro Focus MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 0,0 @@ hightlight id_;_2058267912_;_script infofile_;_ZIP::ssf11.xml_;_
WpfWindow("Micro Focus MyFlight Sample").WpfButton("BACK").Click @@ hightlight id_;_2058204312_;_script infofile_;_ZIP::ssf12.xml_;_
	Next
Next
