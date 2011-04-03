// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PatternSemantics
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CharacterClassTests : SputnikTestFixture
    {
        public CharacterClassTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.2_Pattern_Semantics\15.10.2.13_CharacterClass")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.13")]
        [TestCase("S15.10.2.13_A1_T1.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T10.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T11.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T12.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T13.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T14.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T15.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T16.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T17.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T2.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T3.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T4.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T5.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T6.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T7.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T8.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        [TestCase("S15.10.2.13_A1_T9.js", Description = "The production CharacterClass :: [ [lookahead \\notin {^}] ClassRanges ] evaluates by evaluating ClassRanges to obtain a CharSet and returning that CharSet and the boolean false")]
        public void TheProductionCharacterClassLookaheadNotinClassRangesEvaluatesByEvaluatingClassRangesToObtainACharSetAndReturningThatCharSetAndTheBooleanFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.13")]
        [TestCase("S15.10.2.13_A2_T1.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T2.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T3.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T4.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T5.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T6.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T7.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        [TestCase("S15.10.2.13_A2_T8.js", Description = "The production CharacterClass :: [ ^ ClassRanges ] evaluates by evaluating ClassRanges to  obtain a CharSet and returning that CharSet and the boolean true")]
        public void TheProductionCharacterClassClassRangesEvaluatesByEvaluatingClassRangesToObtainACharSetAndReturningThatCharSetAndTheBooleanTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.13")]
        [TestCase("S15.10.2.13_A3_T1.js", Description = "Inside a CharacterClass, \\b means the backspace character")]
        [TestCase("S15.10.2.13_A3_T2.js", Description = "Inside a CharacterClass, \\b means the backspace character")]
        [TestCase("S15.10.2.13_A3_T3.js", Description = "Inside a CharacterClass, \\b means the backspace character")]
        [TestCase("S15.10.2.13_A3_T4.js", Description = "Inside a CharacterClass, \\b means the backspace character")]
        public void InsideACharacterClassBMeansTheBackspaceCharacter(string file)
        {
            RunFile(file);
        }
    }
}