@echo off

::服务端口
set port=8800
::服务显示名字
set name="FanTest WebAPI Host Service"
::用户
set user=FJ\fan

echo 移除URL保留项(HTTP namespace)
netsh http delete urlacl url=http://+:%port%/service1/
netsh http delete urlacl url=http://+:%port%/service2/
netsh http delete urlacl url=http://+:%port%/service3/

echo 移除IP地址
netsh http delete iplisten ipaddress=0.0.0.0:%port%

echo 移除防火墙规则
netsh advfirewall firewall delete rule name=%name%-%port%

echo 清理完毕！
pause