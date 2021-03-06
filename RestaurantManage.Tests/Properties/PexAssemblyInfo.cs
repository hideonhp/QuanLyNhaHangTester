// <copyright file="PexAssemblyInfo.cs">Copyright ©  2010</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("RestaurantManagerSystem")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("CrystalDecisions.Shared")]
[assembly: PexInstrumentAssembly("CrystalDecisions.Windows.Forms")]
[assembly: PexInstrumentAssembly("CrystalDecisions.ReportSource")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("DevComponents.DotNetBar2")]
[assembly: PexInstrumentAssembly("CrystalDecisions.CrystalReports.Engine")]
[assembly: PexInstrumentAssembly("System.Data")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CrystalDecisions.Shared")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CrystalDecisions.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CrystalDecisions.ReportSource")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevComponents.DotNetBar2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "CrystalDecisions.CrystalReports.Engine")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data")]

