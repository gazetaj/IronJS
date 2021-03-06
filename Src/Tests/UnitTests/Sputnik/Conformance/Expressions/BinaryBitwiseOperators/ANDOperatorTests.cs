// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.BinaryBitwiseOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ANDOperatorTests : SputnikTestFixture
    {
        public ANDOperatorTests()
            : base(@"Conformance\11_Expressions\11.10_Binary_Bitwise_Operators\11.10.1_AND_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [TestCase("S11.10.1_A1.js", Description = "White Space and Line Terminator between BitwiseANDExpression and \"&\" or between \"&\" and EqualityExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenBitwiseANDExpressionAndOrBetweenAndEqualityExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [TestCase("S11.10.1_A2.1_T1.js", Description = "Operator x & y uses GetValue")]
        [TestCase("S11.10.1_A2.1_T2.js", Description = "Operator x & y uses GetValue")]
        [TestCase("S11.10.1_A2.1_T3.js", Description = "Operator x & y uses GetValue")]
        public void OperatorXYUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [Category("ECMA 8.6.2.6")]
        [TestCase("S11.10.1_A2.2_T1.js", Description = "Operator x & y uses [[Default Value]]")]
        public void OperatorXYUsesDefaultValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [TestCase("S11.10.1_A2.3_T1.js", Description = "ToInt32(first expression) is called first, and then ToInt32(second expression)")]
        public void ToInt32FirstExpressionIsCalledFirstAndThenToInt32SecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [TestCase("S11.10.1_A2.4_T1.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.10.1_A2.4_T2.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.10.1_A2.4_T3.js", Description = "First expression is evaluated first, and then second expression")]
        public void FirstExpressionIsEvaluatedFirstAndThenSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.10.1")]
        [TestCase("S11.10.1_A3_T1.1.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T1.2.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T1.3.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T1.4.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T1.5.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.1.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.2.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.3.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.4.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.5.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.6.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.7.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.8.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        [TestCase("S11.10.1_A3_T2.9.js", Description = "Operator x & y returns ToNumber(x) & ToNumber(y)")]
        public void OperatorXYReturnsToNumberXToNumberY(string file)
        {
            RunFile(file);
        }
    }
}