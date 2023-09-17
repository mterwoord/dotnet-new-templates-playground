using Microsoft.TemplateEngine.Authoring.TemplateVerifier;
using Xunit.Abstractions;

namespace Templates.Tests;

public class MyFirstTemplateTests(ITestOutputHelper log): TestBase(log)
{
    [Fact]
    public async Task FirstTemplateTest()
    {
        TemplateVerifierOptions options = new(templateName: "myfirsttemplate")
                                          {
                                              TemplatePath = GetTemplatesFolder(),
                                          };
        
        
      
        VerificationEngine engine = new(Logger);
        await engine.Execute(options);
    }
    
    [Fact]
    public async Task CustomName()
    {
        TemplateVerifierOptions options = new(templateName: "myfirsttemplate")
                                          {
                                              TemplatePath = GetTemplatesFolder(),
                                              TemplateSpecificArgs = new []
                                                                     {
                                                                         "-n", "TestName"
                                                                     }
                                          };
        
        
      
        VerificationEngine engine = new(Logger);
        await engine.Execute(options);
    }
}