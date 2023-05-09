>>>start test
set repl {
@bash:/
node;
@>:/
console.log('Hello World, from the REPL.');
Hello World, from the REPL.;
};
set bat{
@bash :/ code;
@javascript:/console.log('Hello World, from a script file.');
@bash node index.js;
};
compare . & Hello World, from a script file. =1;
if not , then r-all-set;
other then finish test;
end test ;
end process;
end all;
end;