@echo off

::����˿�
set port=8800
::������ʾ����
set name="FanTest WebAPI Host Service"
::�û�
set user=FJ\fan

echo ���URL������(HTTP namespace)
netsh http add urlacl url=http://+:%port%/service1/ user=%user%
netsh http add urlacl url=http://+:%port%/service2/ user=%user%
netsh http add urlacl url=http://+:%port%/service3/ user=%user%

echo ���IP��ַ
netsh http add iplisten ipaddress=0.0.0.0:%port%

echo ��ӷ���ǽ����
netsh advfirewall firewall add rule name=%name%-%port% dir=in action=allow protocol=TCP localport=%port%

echo ע����ϣ�
pause