// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.MultiplicativeOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ApplyingTheAsteriskOperatorTests : SputnikTestFixture
    {
        public ApplyingTheAsteriskOperatorTests()
            : base(@"Conformance\11_Expressions\11.5_Multiplicative_Operators\11.5.1_Applying_the_asterisk_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.5.1_A1.js", Description = "White Space and Line Terminator between MultiplicativeExpression and \"*\" or between \"*\" and UnaryExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenMultiplicativeExpressionAndOrBetweenAndUnaryExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [TestCase("S11.5.1_A2.1_T1.js", Description = "Operator x * y uses GetValue")]
        [TestCase("S11.5.1_A2.1_T2.js", Description = "Operator x * y uses GetValue")]
        [TestCase("S11.5.1_A2.1_T3.js", Description = "Operator x * y uses GetValue")]
        public void OperatorXYUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [Category("ECMA 8.6.2.6")]
        [TestCase("S11.5.1_A2.2_T1.js", Description = "Operator x * y uses [[Default Value]]")]
        public void OperatorXYUsesDefaultValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [TestCase("S11.5.1_A2.3_T1.js", Description = "ToNumber(first expression) is called first, and then ToNumber(second expression)")]
        public void ToNumberFirstExpressionIsCalledFirstAndThenToNumberSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [TestCase("S11.5.1_A2.4_T1.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.5.1_A2.4_T2.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.5.1_A2.4_T3.js", Description = "First expression is evaluated first, and then second expression")]
        public void FirstExpressionIsEvaluatedFirstAndThenSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [TestCase("S11.5.1_A3_T1.1.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T1.2.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T1.3.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T1.4.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T1.5.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.1.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.2.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.3.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.4.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.5.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.6.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.7.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.8.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        [TestCase("S11.5.1_A3_T2.9.js", Description = "Operator x * y returns ToNumber(x) * ToNumber(y)")]
        public void OperatorXYReturnsToNumberXToNumberY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.5.1")]
        [TestCase("S11.5.1_A4_T1.1.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T1.2.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T2.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T3.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T4.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T5.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T6.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T7.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        [TestCase("S11.5.1_A4_T8.js", Description = "The result of a floating-point multiplication is governed by the rules of IEEE 754 double-precision arithmetics")]
        public void TheResultOfAFloatingPointMultiplicationIsGovernedByTheRulesOfIEEE754DoublePrecisionArithmetics(string file)
        {
            RunFile(file);
        }
    }
}