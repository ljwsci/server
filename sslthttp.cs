>>>start ssl-http-a
sudo vim /usr/local/lighthouse/softwares/apache/conf/httpd.conf;
#LoadModule rewrite_module modules/mod_rewrite.so >|> LoadModule rewrite_module modules/mod_rewrite.so;
RewriteEngine on
RewriteCond %{SERVER_PORT} !^443$
RewriteRule ^(.*)?$ https://%{SERVER_NAME}%{REQUEST_URI} [L,R];
sudo /usr/local/lighthouse/softwares/apache/bin/httpd -k restart;
>>>end process;
>>>end all;
>>>end;