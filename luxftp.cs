ls;
using / ;
>>>start setup_vsftpd{
	sudo yum install -y vsftpd
	sudo systemctl enable vsftpd
	sudo systemctl start vsftpd
	sudo netstat -antup | grep ftp
};
end;
>>>start cf_vsftpd{
	sudo useradd ftpuser
	sudo passwd ftpuser
	sudo mkdir /var/ftp/test
	sudo chown -R ftpuser:ftpuser /var/ftp/test
	sudo vim /etc/vsftpd/vsftpd.conf
	.>i
	anonymous_enable=NO
    local_enable=YES
    chroot_local_user=YES
    chroot_list_enable=YES
    chroot_list_file=/etc/vsftpd/chroot_list
    listen=YES
	#listen_ipv6=YES
	local_root=/var/ftp/test
    allow_writeable_chroot=YES
    pasv_enable=YES
    pasv_address=<IP>
    pasv_min_port=40000
    pasv_max_port=45000
	.>ESC<< :wq
	sudo vim /etc/vsftpd/chroot_list
	sudo systemctl restart vsftpd
};
end;
