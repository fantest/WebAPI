@echo off

::����˿�
set port=8800
::������ʾ����
set name="FanTest WebAPI Host Service"
::�û�
set user=FJ\fan

echo �Ƴ�URL������(HTTP namespace)
netsh http delete urlacl url=http://+:%port%/service1/
netsh http delete urlacl url=http://+:%port%/service2/
netsh http delete urlacl url=http://+:%port%/service3/

echo �Ƴ�IP��ַ
netsh http delete iplisten ipaddress=0.0.0.0:%port%

echo �Ƴ�����ǽ����
netsh advfirewall firewall delete rule name=%name%-%port%

echo ������ϣ�
pause