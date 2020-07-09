'Note - currently set to only run starting from 

bookFlight = true ' set to false to lookup, but not book
Set fromCityDesc = Description.Create()
fromCityDesc("devnamepath").value= "fromCity"
Set toCityDesc = Description.Create()
toCityDesc("devnamepath").value= "toCity"

fromCitiesItems = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").GetROProperty("all items")
fromCities = split(fromCitiesItems,vblf)

For fromCityIndex = 0 To ubound(fromCities)
' Use one of the following two lines
	WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").select fromCityIndex ' normal
'	WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("fromCity").select "Seattle" ' if you want to test a specific city pair
	toCitiesItems = WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").GetROProperty("all items")
	toCities = split(toCitiesItems,vblf)

For toCityIndex = 0 To ubound(toCities)
	If fromCities(fromCityIndex) <> toCities(toCityIndex) Then
' Again, use one of the following 2 lines
			WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").Select toCityIndex ' normal
'			WpfWindow("Micro Focus MyFlight Sample").WpfComboBox("toCity").Select "Zurich" ' use for a specific city
			WpfWindow("Micro Focus MyFlight Sample").WpfCalendar("datePicker").SetDate "22-Aug-2021" @@ hightlight id_;_2058268008_;_script infofile_;_ZIP::ssf9.xml_;_
			WpfWindow("Micro Focus MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_2058203544_;_script infofile_;_ZIP::ssf10.xml_;_
			If WpfWindow("Micro Focus MyFlight Sample").WpfButton("BACK").exist(10) then
				print  "Flying from " & fromCities(fromCityIndex) & " to " & toCities(toCityIndex)
				'reporter.ReportEvent micFail, "checkCities", "Flying from " &FromCity& " to " ToCity
				fromCityDesc("name").value= "From: " & fromCities(fromCityIndex)
				If not WpfWindow("Micro Focus MyFlight Sample").WpfObject(fromCityDesc).Exist (3) then
					wrongFromCity = WpfWindow("Micro Focus MyFlight Sample").WpfObject("From city").GetROProperty("name")
					print  "from city is wrong. Found " & wrongFromCity
					reporter.ReportEvent micFail, "checkCities", "from city is wrong. Found " & wrongFromCity _
						& vblf & "with To city of " & toCities(toCityIndex)
				End If
				
				toCityDesc("name").value= "To: " & toCities(toCityIndex)
				If not WpfWindow("Micro Focus MyFlight Sample").WpfObject(toCityDesc).Exist (3) then
					wrongToCity = pfWindow("Micro Focus MyFlight Sample").WpfObject("To city").GetROProperty("name")
					print  "to city is wrong. Found " & wrongToCity
					reporter.ReportEvent micFail, "checkCities", "to city is wrong. Found " & wrongToCity _
						& VBLF & "with From city of " & fromCities(fromCityIndex) 
					
				End If
				If bookFlight Then				
					WpfWindow("Micro Focus MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 0,0 @@ hightlight id_;_1898179160_;_script infofile_;_ZIP::ssf13.xml_;_
					WpfWindow("Micro Focus MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1895038128_;_script infofile_;_ZIP::ssf14.xml_;_
					WpfWindow("Micro Focus MyFlight Sample").WpfEdit("passengerName").Set DataTable("passengerName", dtGlobalSheet) @@ hightlight id_;_1898238488_;_script infofile_;_ZIP::ssf16.xml_;_
DataTable.SetNextRow
					WpfWindow("Micro Focus MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_2088944272_;_script infofile_;_ZIP::ssf19.xml_;_
					if WpfWindow("Micro Focus MyFlight Sample").WpfObject("Order completed").Exist(20) then @@ hightlight id_;_1889093752_;_script infofile_;_ZIP::ssf18.xml_;_
					end if
					WpfWindow("Micro Focus MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_2102215912_;_script infofile_;_ZIP::ssf20.xml_;_
				else
					WpfWindow("Micro Focus MyFlight Sample").WpfButton("BACK").Click
				End If
			else
				reporter.ReportEvent micFail, "checkCities", "No flights from " & fromCities(fromCityIndex) _
				& " to " & toCities(toCityIndex)
			end if 
		End If
	Next
Next
