start test url_server {
ping //url_server/
if ans = Y then send "Server Normal";
other then send "Server ERROR";
};
start test UI {
if UI MODEL = Y then send "Server Normal";
other then send "UI ERROR";
end process;
end all;
end;
