grammar Grund;

program: line* EOF;

line: statement | ifBlock | whileBlock | functionDefinition | functionCall | elseIfBlock | assignment | listAccession; 

statement: (assignment | functionCall)';';

ifBlock: IFBLOCK  expression  block | IFBLOCK  expression  block ('ELSE' elseIfBlock);

elseIfBlock: block | ifBlock;

IFBLOCK: 'IF';
 
whileBlock: WHILE expression block | WHILE expression block ('ELSE' elseIfBlock);

WHILE: 'WHILE' | 'UNLESS';

assignment: IDENTIFIER '='  expression | listAccession '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

FUNC: 'FUNK';
paramater: IDENTIFIER;

functionDefinition: FUNC IDENTIFIER '(' (paramater (',' paramater)*)? ')' block;
listAccession: IDENTIFIER '[' expression ']';

expression
    : constant              #constantExpression
    | collections           #collectionsExpression
    | listAccession         #listAccessionExpression
    | IDENTIFIER            #identifierExpression
    | functionDefinition    #functionDefinitionExpression
    | functionCall          #functionCallExpression
    | '(' expression ')'    #parenthesizedExpression
    | '!' expression        #notExpression
    | expression multOP expression  #multiplicativeExpression
    | expression addOP expression  #additiveExpression
    | expression compareOP expression #comparisonExpression
    | expression boolOP expression #booleanExpression
    ;
multOP: '*'|'/'|'%';
addOP:'+'|'-';
compareOP:'=='|'!='|'>'|'<'|'>='|'<=';
boolOP: BOOL_OPERATOR;

BOOL_OPERATOR:'AND'|'OR';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;
collections: list | dictionary;
list:'[' (expression (',' expression)*)? ']';
dictionary: '{' (( STRING ':' expression ',')*( STRING ':' expression))? '}';
INTEGER:'-'?[0-9]+;
FLOAT:'-'?[0-9]+ '.' [0-9]+;
STRING: ('"' ~'"'* '"')|('\'' ~'\''* '\'');
BOOL: 'true' | 'false';
NULL: 'NULL';


block: ':' line* 'END';

WS : [ \t\r\n]+ -> skip;
LINE_COMMENT:'//' ~[\r\n]* -> skip;

IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
