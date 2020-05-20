/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘deleteOrder.st’ 
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
    	
    	public BindDirection bind_dir14 = null;
        public BindDirection bind_dir15 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity13 = null;
        public BindDirection bind_dir16 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity13_Policy = null;
        public BindDirection bind_dir17 = null;
        public BindDirection bind_dir18 = null;
        public BindDirection bind_dir19 = null;
        
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
            
            
        
        	_flow.DataFetchActivity9 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity9");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.ForEach);
            _flow.DataExporterActivity11 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity11");
            _flow.DataExporterCloseActivity12 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity12");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity10 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity10");
            this.DataCursorActivity13 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity13");
            this.DataCursorActivity13_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence7 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence7");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.Loop6 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop6Input>(_context,"Loop6",LoopType.For);
            _flow.Sequence8 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence8");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.DataFetchActivity9.Comment = @"";
            _flow.DataFetchActivity9.IconPath = @"";
            _flow.DataFetchActivity9.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity9.QueryClassName = @"HP.ST.Ext.CustomDataProviders.LocalDataQuery";
            XmlDocument DataFetchActivity9_QueryParameters_Document = new XmlDocument();
            DataFetchActivity9_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity9Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>a5bb1000-ac05-476d-86b7-cb94a760d004</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>persons</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>True</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value></Value></QueryParameter><QueryParameter><Name>TableStructure</Name><Value>name,String,</Value></QueryParameter><QueryParameter><Name>TableContents</Name><Value>a^b^j</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity9_QueryParameters_Document.LoadXml(xmlDataFetchActivity9Params);
            _flow.DataFetchActivity9.QueryParameters = DataFetchActivity9_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("persons", _flow.DataFetchActivity9);
            this.Activities.Add (_flow.DataFetchActivity9);
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
            _flow.Loop2.ConditionAsString = @"For each item in {DataSource.persons}";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Condition += delegate(object sender,STActivityBaseEventArgs e)
            {
            return !DataCursorActivity13.IsAtEndPosition;
            };
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity13);
            _flow.Loop2.Activities.Add (_flow.Sequence7);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity11.Comment = @"";
            _flow.DataExporterActivity11.IconPath = @"";
            VTDPropertyInfoBase pi28 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter15 = new VTDObjectGetter(pi28);
            VTDPropertyInfoBase pi29 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter14 = new VTDObjectSetter(pi29);
            binding_setter14 = new StringFormaterDecorator(binding_setter14,"{Step.DataFetchActivity9.OutTable}");
            bind_dir14 = new BindDirection(_flow.DataFetchActivity9,binding_getter15,binding_setter14,BindTargetType.ToInProperty);
            _flow.DataExporterActivity11.InDirections.Add(bind_dir14);
            this.Activities.Add (_flow.DataExporterActivity11);
            _flow.DataExporterCloseActivity12.Comment = @"";
            _flow.DataExporterCloseActivity12.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity12);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity10.Comment = @"";
            _flow.DataDisconnectActivity10.IconPath = @"";
            VTDPropertyInfoBase pi30 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter16 = new VTDObjectGetter(pi30);
            VTDPropertyInfoBase pi31 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter15 = new VTDObjectSetter(pi31);
            binding_setter15 = new StringFormaterDecorator(binding_setter15,"{Step.DataFetchActivity9.OutTable}");
            bind_dir15 = new BindDirection(_flow.DataFetchActivity9,binding_getter16,binding_setter15,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity10.InDirections.Add(bind_dir15);
            this.Activities.Add (_flow.DataDisconnectActivity10);
            this.DataCursorActivity13.Comment = @"";
            this.DataCursorActivity13.IconPath = @"";
            VTDPropertyInfoBase pi32 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter17 = new VTDObjectGetter(pi32);
            VTDPropertyInfoBase pi33 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter16 = new VTDObjectSetter(pi33);
            binding_setter16 = new StringFormaterDecorator(binding_setter16,"{Step.DataFetchActivity9.OutTable}");
            bind_dir16 = new BindDirection(_flow.DataFetchActivity9,binding_getter17,binding_setter16,BindTargetType.ToInProperty);
            this.DataCursorActivity13.InDirections.Add(bind_dir16);
            this.DataCursorActivity13_Policy.StartPosition = CursorStartPosition.FirstRecord;
            this.DataCursorActivity13_Policy.StartAtSpecificRow = 1;
            this.DataCursorActivity13_Policy.StartCondition.ColumnName = "";
            this.DataCursorActivity13_Policy.StartCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity13_Policy.StartCondition.Value = "";
            this.DataCursorActivity13_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity13_Policy.EndAtSpecificRow = 1;
            this.DataCursorActivity13_Policy.EndCondition.ColumnName = "";
            this.DataCursorActivity13_Policy.EndCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity13_Policy.EndCondition.Value = "";
            this.DataCursorActivity13_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity13_Policy.StepSize = 1;
            this.DataCursorActivity13_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Wraparound;
            this.DataCursorActivity13.Policy = this.DataCursorActivity13_Policy;
            this.DataCursorActivity13.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity13.ResetCursor;
            _flow.Sequence7.Comment = @"";
            _flow.Sequence7.IconPath = @"";
            _flow.Sequence7.Name = @"Sequence7";
            _flow.Sequence7.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence7.Activities.Add (_flow.Loop6);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrders xmlns=""HP.SOAQ.SampleApp""><FlightsDetails><CustomerName>{DataSource.persons.name}</CustomerName></FlightsDetails></GetFlightOrders></Body></Envelope>");
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
            VTDPropertyInfoBase pi34 = new VTDPropertyInfoBase("name");
            VTDBaseGetter binding_getter18 = new VTDObjectGetter(pi34);
            VTDPropertyInfoBase pi35 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrders'][1]/*[local-name(.)='FlightsDetails'][1]/*[local-name(.)='CustomerName'][1]");
            VTDBaseSetter binding_setter17 = new VTDXPathSetter(pi35,XmlTypeCode.String);
            binding_setter17 = new StringFormaterDecorator(binding_setter17,"{DataSource.persons.name}");
            bind_dir17 = new BindDirection(this.DataCursorActivity13,binding_getter18,binding_setter17,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir17);
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrdersResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightOrdersResult><FlightOrder><CustomerName p1:nil=""true"" /><OrderNumber /></FlightOrder></GetFlightOrdersResult></GetFlightOrdersResponse></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            _flow.Loop6.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop6.NumberOfIterations = (int)1;
            _flow.Loop6.Comment = @"";
            _flow.Loop6.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop6.Name = @"Loop6";
            VTDPropertyInfoBase pi36 = new VTDPropertyInfoBase("OutputEnvelope","count(/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'])");
            VTDBaseGetter binding_getter19 = new VTDXPathGetter(pi36);
            VTDPropertyInfoBase pi37 = new VTDPropertyInfoBase("NumberOfIterations");
            VTDBaseSetter binding_setter18 = new VTDObjectSetter(pi37);
            bind_dir18 = new BindDirection(_flow.StServiceCallActivity4,binding_getter19,binding_setter18,BindTargetType.ToInProperty);
            _flow.Loop6.InDirections.Add(bind_dir18);
            _flow.Loop6.Activities.Add (_flow.Sequence8);
            _flow.Sequence8.Comment = @"";
            _flow.Sequence8.IconPath = @"";
            _flow.Sequence8.Name = @"Sequence8";
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrder xmlns=""HP.SOAQ.SampleApp""><OrderNumber>{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightOrdersResponse.GetFlightOrdersResult.FlightOrder[{Step.OutputProperties.Loop6.CurrentIterationNumber}].OrderNumber}</OrderNumber></DeleteFlightOrder></Body></Envelope>");
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
            VTDPropertyInfoBase pi38 = new VTDPropertyInfoBase("CurrentIterationNumber");
            VTDBaseGetter binding_getter20 = new VTDObjectGetter(pi38);
            VTDPropertyInfoBase pi39 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightOrdersResponse'][1]/*[local-name(.)='GetFlightOrdersResult'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseGetter binding_getter21 = new VTDXPathGetter(pi39,XmlTypeCode.Int);
            binding_getter21 = new XPathGetterDecorator(binding_getter21,"{Array0}",binding_getter20,_flow.Loop6);
            VTDPropertyInfoBase pi40 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='DeleteFlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseSetter binding_setter19 = new VTDXPathSetter(pi40,XmlTypeCode.Int);
            bind_dir19 = new BindDirection(_flow.StServiceCallActivity4,binding_getter21,binding_setter19,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir19);
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            
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
    