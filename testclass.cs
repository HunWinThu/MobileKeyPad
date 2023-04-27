using Xunit;
using System;
using System.IO;
using System.Text;

public class ProgramTests
{
   [Theory]
   [InlineData("4433555 555666#", "HELLO")]
   [InlineData("77776667777#", "SOS")]
   [InlineData("44883336**6647778*999#", "HUNGRY")]

   [InlineData("8 88777444666*664#", "TURING")]
   public void PrintSentence_ReturnsExpectedOutput(string input, string expectedOutput)
   {
      // Arrange
      StringBuilder output = new StringBuilder();
      Console.SetOut(new StringWriter(output));

      // Act
      Program.OldPhonePad(input);
      string actualOutput = output.ToString().Trim();

      // Assert
      Assert.Equal(expectedOutput, actualOutput);
   }
}
