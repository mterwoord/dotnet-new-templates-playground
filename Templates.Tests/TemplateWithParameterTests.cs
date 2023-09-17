using Microsoft.TemplateEngine.Authoring.TemplateVerifier;
using Xunit.Abstractions;

namespace Templates.Tests;

public class TemplateWithParameterTests(ITestOutputHelper log): TestBase(log)
{
    [Fact]
    public async Task WithoutSpecifyingParameter()
    {
        TemplateVerifierOptions options = new(templateName: "templatewithparameter")
                                          {
                                              TemplatePath = GetTemplatesFolder(),
                                          };
        
        
      
        VerificationEngine engine = new(Logger);
        await engine.Execute(options);
    }
    
    [Fact]
    public async Task Parameter_false()
    {
        TemplateVerifierOptions options = new(templateName: "templatewithparameter")
                                          {
                                              TemplatePath = GetTemplatesFolder(),
                                              TemplateSpecificArgs = new []
                                                                     {
                                                                         "--UseConsole", "false"
                                                                     }
                                          };
        
        
      
        VerificationEngine engine = new(Logger);
        await engine.Execute(options);
    }
    
    [Fact]
    public async Task Parameter_yes()
    {
        TemplateVerifierOptions options = new(templateName: "templatewithparameter")
                                          {
                                              TemplatePath = GetTemplatesFolder(),
                                              TemplateSpecificArgs = new []
                                                                     {
                                                                         "--UseConsole", "yes"
                                                                     }
                                          };
        
        
      
        VerificationEngine engine = new(Logger);
        await engine.Execute(options);
    }
}