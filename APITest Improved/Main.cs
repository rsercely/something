/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘APITest Improved.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir36 = null;
        public BindDirection bind_dir37 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity16 = null;
        public BindDirection bind_dir38 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity16_Policy = null;
        public BindDirection bind_dir39 = null;
        public BindDirection bind_dir40 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity12 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity12");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.ForEach);
            _flow.DataExporterActivity14 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity14");
            _flow.DataExporterCloseActivity15 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity15");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity13 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity13");
            this.DataCursorActivity16 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity16");
            this.DataCursorActivity16_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence11 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence11");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.IfElse6 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse6Input>(_context,"IfElse6");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.IfElseBranch7 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch(_context,"IfElseBranch7");
            _flow.IfElseBranch8 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch(_context,"IfElseBranch8");
            _flow.Continue10 = new HP.ST.Fwk.RunTimeFWK.Continue(_context,"Continue10");
            _flow.DataFetchActivity12.Comment = @"";
            _flow.DataFetchActivity12.IconPath = @"";
            _flow.DataFetchActivity12.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity12.QueryClassName = @"HP.ST.Ext.CustomDataProviders.LocalDataQuery";
            XmlDocument DataFetchActivity12_QueryParameters_Document = new XmlDocument();
            DataFetchActivity12_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity12Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>673e4126-d5db-42f5-85ad-f18ffcfce164</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>customers</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>True</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value></Value></QueryParameter><QueryParameter><Name>TableStructure</Name><Value>initial,String,</Value></QueryParameter><QueryParameter><Name>TableContents</Name><Value>axaxax^b^e^xxxx</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity12_QueryParameters_Document.LoadXml(xmlDataFetchActivity12Params);
            _flow.DataFetchActivity12.QueryParameters = DataFetchActivity12_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("customers", _flow.DataFetchActivity12);
            this.Activities.Add (_flow.DataFetchActivity12);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"For each item in {DataSource.customers}";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Condition += delegate(object sender,STActivityBaseEventArgs e)
            {
            return !DataCursorActivity16.IsAtEndPosition;
            };
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity16);
            _flow.Loop2.Activities.Add (_flow.Sequence11);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity14.Comment = @"";
            _flow.DataExporterActivity14.IconPath = @"";
            VTDPropertyInfoBase pi74 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter39 = new VTDObjectGetter(pi74);
            VTDPropertyInfoBase pi75 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter36 = new VTDObjectSetter(pi75);
            binding_setter36 = new StringFormaterDecorator(binding_setter36,"{Step.DataFetchActivity12.OutTable}");
            bind_dir36 = new BindDirection(_flow.DataFetchActivity12,binding_getter39,binding_setter36,BindTargetType.ToInProperty);
            _flow.DataExporterActivity14.InDirections.Add(bind_dir36);
            this.Activities.Add (_flow.DataExporterActivity14);
            _flow.DataExporterCloseActivity15.Comment = @"";
            _flow.DataExporterCloseActivity15.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity15);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity13.Comment = @"";
            _flow.DataDisconnectActivity13.IconPath = @"";
            VTDPropertyInfoBase pi76 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter40 = new VTDObjectGetter(pi76);
            VTDPropertyInfoBase pi77 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter37 = new VTDObjectSetter(pi77);
            binding_setter37 = new StringFormaterDecorator(binding_setter37,"{Step.DataFetchActivity12.OutTable}");
            bind_dir37 = new BindDirection(_flow.DataFetchActivity12,binding_getter40,binding_setter37,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity13.InDirections.Add(bind_dir37);
            this.Activities.Add (_flow.DataDisconnectActivity13);
            this.DataCursorActivity16.Comment = @"";
            this.DataCursorActivity16.IconPath = @"";
            VTDPropertyInfoBase pi78 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter41 = new VTDObjectGetter(pi78);
            VTDPropertyInfoBase pi79 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter38 = new VTDObjectSetter(pi79);
            binding_setter38 = new StringFormaterDecorator(binding_setter38,"{Step.DataFetchActivity12.OutTable}");
            bind_dir38 = new BindDirection(_flow.DataFetchActivity12,binding_getter41,binding_setter38,BindTargetType.ToInProperty);
            this.DataCursorActivity16.InDirections.Add(bind_dir38);
            this.DataCursorActivity16_Policy.StartPosition = CursorStartPosition.FirstRecord;
            this.DataCursorActivity16_Policy.StartAtSpecificRow = 1;
            this.DataCursorActivity16_Policy.StartCondition.ColumnName = "";
            this.DataCursorActivity16_Policy.StartCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity16_Policy.StartCondition.Value = "";
            this.DataCursorActivity16_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity16_Policy.EndAtSpecificRow = 1;
            this.DataCursorActivity16_Policy.EndCondition.ColumnName = "";
            this.DataCursorActivity16_Policy.EndCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity16_Policy.EndCondition.Value = "";
            this.DataCursorActivity16_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity16_Policy.StepSize = 1;
            this.DataCursorActivity16_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Wraparound;
            this.DataCursorActivity16.Policy = this.DataCursorActivity16_Policy;
            this.DataCursorActivity16.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity16.ResetCursor;
            _flow.Sequence11.Comment = @"";
            _flow.Sequence11.IconPath = @"";
            _flow.Sequence11.Name = @"Sequence11";
            _flow.Sequence11.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence11.Activities.Add (_flow.IfElse6);
            _flow.Sequence11.Activities.Add (_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrders xmlns=""HP.SOAQ.SampleApp""><FlightsDetails><CustomerName>{DataSource.customers.initial}</CustomerName></FlightsDetails></GetFlightOrders></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"GetFlightOrders";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlightOrders";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"GetFlightOrders";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi80 = new VTDPropertyInfoBase("initial");
            VTDBaseGetter binding_getter42 = new VTDObjectGetter(pi80);
            VTDPropertyInfoBase pi81 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrders'][1]/*[local-name(.)='FlightsDetails'][1]/*[local-name(.)='CustomerName'][1]");
            VTDBaseSetter binding_setter39 = new VTDXPathSetter(pi81,XmlTypeCode.String);
            binding_setter39 = new StringFormaterDecorator(binding_setter39,"{DataSource.customers.initial}");
            bind_dir39 = new BindDirection(this.DataCursorActivity16,binding_getter42,binding_setter39,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir39);
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrdersResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightOrdersResult><FlightOrder><CustomerName p1:nil=""true"" /><OrderNumber /></FlightOrder></GetFlightOrdersResult></GetFlightOrdersResponse></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            _flow.IfElse6.ConditionAsString = @"{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightOrdersResponse.GetFlightOrdersResult.FlightOrder.Count} GreaterThan 0";
            _flow.IfElse6.Comment = @"";
            _flow.IfElse6.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_if_else.png";
            _flow.IfElse6.Name = @"Condition6";
            _flow.IfElse6.Activities.Add (_flow.IfElseBranch7);
            _flow.IfElse6.Activities.Add (_flow.IfElseBranch8);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrder xmlns=""HP.SOAQ.SampleApp""><OrderNumber>{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightOrdersResponse.GetFlightOrdersResult.FlightOrder[1].OrderNumber}</OrderNumber></DeleteFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity5.InputEnvelope = StServiceCallActivity5_InputEnvelope_Document;
            _flow.StServiceCallActivity5.Comment = @"";
            _flow.StServiceCallActivity5.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity5.Name = @"DeleteFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/DeleteFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity5.Service = @"Flights_Service";
            _flow.StServiceCallActivity5.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity5.Operation = @"DeleteFlightOrder";
            _flow.StServiceCallActivity5.IsOneWay = false;
            _flow.StServiceCallActivity5.SendRequestToService=true;
            _flow.StServiceCallActivity5.FaultExpected=false;
            _flow.StServiceCallActivity5.IsAsync=false;
            _flow.StServiceCallActivity5.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity5.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi82 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseGetter binding_getter43 = new VTDXPathGetter(pi82,XmlTypeCode.Int);
            binding_getter43 = new XPathGetterDecorator(binding_getter43,"{Array0}",1);
            VTDPropertyInfoBase pi83 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='DeleteFlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseSetter binding_setter40 = new VTDXPathSetter(pi83,XmlTypeCode.Int);
            bind_dir40 = new BindDirection(_flow.StServiceCallActivity4,binding_getter43,binding_setter40,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir40);
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><DeleteFlightOrderResult>true</DeleteFlightOrderResult></DeleteFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            _flow.IfElseBranch7.Condition += delegate(object sender,EventArgs e)
            {
            	try
            	{
            VTDPropertyInfoBase pi84 = new VTDPropertyInfoBase("OutputEnvelope","count(/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'])");
            VTDBaseGetter binding_getter44 = new VTDXPathGetter(pi84);
            		System.Int32 expr00 = (System.Int32)HP.ST.Fwk.RunTimeFWK.Utilities.Utils.ConvertValue(_flow.StServiceCallActivity4.GetParam(binding_getter44),typeof(System.Int32));
            		var result0 = expr00;
            		System.Int32 result1 = (System.Int32)(0);
            		return (result0 > result1);
            	}
            	catch(Exception exp)
            	{
            		if (exp is System.InvalidCastException)
            		{
            			throw;
            		}
            		else
            		{
            			return false;
            		}
            	};
            };
            _flow.IfElseBranch7.Comment = @"";
            _flow.IfElseBranch7.IconPath = @"";
            _flow.IfElseBranch7.Name = @"Yes";
            _flow.IfElseBranch8.Condition += delegate(object sender,EventArgs e)
            {
            return true;
            };
            _flow.IfElseBranch8.Comment = @"";
            _flow.IfElseBranch8.IconPath = @"";
            _flow.IfElseBranch8.Name = @"No";
            _flow.IfElseBranch8.Activities.Add (_flow.Continue10);
            _flow.Continue10.Comment = @"";
            _flow.Continue10.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_continue_loop.png";
            _flow.Continue10.Name = @"Continue10";
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    