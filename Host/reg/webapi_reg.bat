@echo off

::服务端口
set port=8800
::服务显示名字
set name="FanTest WebAPI Host Service"
::用户
set user=FJ\fan

echo 添加URL保留项(HTTP namespace)
netsh http add urlacl url=http://+:%port%/service1/ user=%user%
netsh http add urlacl url=http://+:%port%/service2/ user=%user%
netsh http add urlacl url=http://+:%port%/service3/ user=%user%

echo 添加IP地址
netsh http add iplisten ipaddress=0.0.0.0:%port%

echo 添加防火墙规则
netsh advfirewall firewall add rule name=%name%-%port% dir=in action=allow protocol=TCP localport=%port%

echo 注册完毕！
pause