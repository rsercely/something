Set fromCityDesc = Description.Create()
fromCityDesc("devnamepath").value= "fromCity"
Set toCityDesc = Description.Create()
toCityDesc("devnamepath").value= "toCity"

fromCitiesItems = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").GetROProperty("all items")
fromCities = split(fromCitiesItems,vblf)

For fromCityIndex = 0 To ubound(fromCities)-1
	WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").select fromCityIndex
	toCitiesItems = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").GetROProperty("all items")
	toCities = split(toCitiesItems,vblf)
	For toCityIndex = 0 To ubound(toCities)-1
		If fromCities(fromCityIndex) <> toCities(toCityIndex) Then
			WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").Select toCityIndex
			WpfWindow("Micro Focus MyFlight Sample").WpfCalendar("datePicker").SetDate "22-Aug-2020" @@ hightlight id_;_2058268008_;_script infofile_;_ZIP::ssf9.xml_;_
			WpfWindow("Micro Focus MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_2058203544_;_script infofile_;_ZIP::ssf10.xml_;_
			If WpfWindow("Micro Focus MyFlight Sample").WpfTable("flightsDataGrid").Exist (10) then
				print  "Flying from " & fromCities(fromCityIndex) & " to " & toCities(toCityIndex)
				'reporter.ReportEvent micFail, "checkCities", "Flying from " &FromCity& " to " ToCity
				fromCityDesc("name").value= "From: " & fromCities(fromCityIndex)
				If not WpfWindow("Micro Focus MyFlight Sample").WpfObject(fromCityDesc).Exist (10) then
					wrongFromCity = WpfWindow("Micro Focus MyFlight Sample").WpfObject("To city").GetROProperty("name")
					print  "from city is wrong. Found" & wrongFromCity
				End If
				WpfWindow("Micro Focus MyFlight Sample").WpfObject("From c5ty").Click


				toCityDesc("name").value= "To: " & toCities(toCityIndex)
				If not WpfWindow("Micro Focus MyFlight Sample").WpfObject(toCityDesc).Exist (10) then
					wrongToCity = toCityDesc("name").value= "To: " & toCities(toCityIndex).GetROProperty("name")
					print  "to city is wrong. Found" & wrongToCity
				End If
				
				WpfWindow("Micro Focus MyFlight Sample").WpfButton("BACK").Click
			else
				reporter.ReportEvent micFail, "checkCities", "No flights from " & fromCities(fromCityIndex) _
				& " to " & toCities(toCityIndex)
			end if 
		End If @@ hightlight id_;_2058267672_;_script infofile_;_ZIP::ssf7.xml_;_
	Next
Next
