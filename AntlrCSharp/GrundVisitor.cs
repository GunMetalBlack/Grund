//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from e:\coding\test\AntlrCSharp\Grund.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GrundParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IGrundVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] GrundParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] GrundParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] GrundParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] GrundParser.IfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfBlock([NotNull] GrundParser.ElseIfBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] GrundParser.WhileBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] GrundParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] GrundParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.inLineIncrement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInLineIncrement([NotNull] GrundParser.InLineIncrementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] GrundParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDefinition([NotNull] GrundParser.FunctionDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.listAccession"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListAccession([NotNull] GrundParser.ListAccessionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>collectionsExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollectionsExpression([NotNull] GrundParser.CollectionsExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] GrundParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] GrundParser.ConstantExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] GrundParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] GrundParser.IdentifierExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>functionDefinitionExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDefinitionExpression([NotNull] GrundParser.FunctionDefinitionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpression([NotNull] GrundParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] GrundParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] GrundParser.ComparisonExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>listAccessionExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListAccessionExpression([NotNull] GrundParser.ListAccessionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] GrundParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="GrundParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanExpression([NotNull] GrundParser.BooleanExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.multOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultOP([NotNull] GrundParser.MultOPContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.addOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOP([NotNull] GrundParser.AddOPContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.compareOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOP([NotNull] GrundParser.CompareOPContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.inLineOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInLineOP([NotNull] GrundParser.InLineOPContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.boolOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOP([NotNull] GrundParser.BoolOPContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] GrundParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.collections"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollections([NotNull] GrundParser.CollectionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] GrundParser.ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.dictionary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionary([NotNull] GrundParser.DictionaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GrundParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] GrundParser.BlockContext context);
}
