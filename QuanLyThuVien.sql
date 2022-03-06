

create database QuanLyThuVien
go

use QuanLyThuVien

-- Tạo bảng độc giả
create table tblDocGia
(
	MaDG varchar(10) constraint pk_tblDocGia primary key,
	TenDG nvarchar(30),
	GioiTinhDG nvarchar(5),
	NgaySinhDG varchar(10),
	SDTDG int,
	DiaChiDG nvarchar(50),
	LoaiDG nvarchar(20),
	GhiChu nvarchar(30),
	TenTaiKhoanDG varchar(10),
	MatKhauDG varchar(20),
)

drop table tblDocGia

-- Tạo bảng Sách
create table tblTaiLieu
(
	MaTaiLieu varchar(10) constraint pk_tblTaiLieu primary key,
	TenTaiLieu nvarchar(50),
	TheLoai nvarchar(30),
	TacGia nvarchar(30),
	NXB nvarchar(30),
	NamXB int,
	DonGia int,
	GhiChu nvarchar(30),
)
drop table tblTaiLieu

-- Tạo bản Mượn
create table tblPhieuMuon
(
	MaPhieu varchar(10),
	MaTT varchar(10),
	MaDG varchar(10),
	GhiChu nvarchar(75),
	constraint pk_tblPhieuMuon primary key(MaPhieu),
	constraint fk_tblPhieuMuon_tblThuThu foreign key(MaTT) references tblThuThu(MaTT),
	constraint fk_tblPhieuMuon_tblDocGia foreign key(MaDG) references tblDocGia(MaDG),
)

drop table tblPhieuMuon

drop table tblPhieuMuon
select * from tblPhieuMuon
-- Tạo bảng Tài khoản thủ thư
create table tblThuThu
(
	MaTT varchar(10) constraint pk_tblThuThu primary key,
	TenTT nvarchar(30),
	GioiTinhTT nvarchar(5),
	NgaySinhTT varchar(10),
	SDTTT int,
	DiaChiTT nvarchar(50),
	TenTaiKhoanTT varchar(10),
	MatKhauTT varchar(20),
)

create table tblCTPM
(
	MaPhieu varchar(10),
	MaTaiLieu varchar(10),
	NgayMuon nvarchar(10),
	NgayTra nvarchar(10),
	constraint pk_tblCTPM primary key (MaPhieu, MaTaiLieu),
	constraint fk_tblCTPM_tblPhieuMuon foreign key(MaPhieu) references tblPhieuMuon(MaPhieu),
	constraint fk_tblCTPM_tblTaiLieu foreign key(MaTaiLieu) references tblTaiLieu(MaTaiLieu),
)
drop table tblCTPM

-- chèn dữ liệu đọc giả
insert into tblDocGia values ('DG001',N'Vũ Đình Mạnh',N'Nam','15/06/1999','0974633324',N'96 Định Công, Hà Nội',N'Sinh viên','...','DG001','123')
insert into tblDocGia values ('DG002',N'Nguyễn Tài Hải',N'Nam','14/04/1998','045693224',N'96 Định Công, Hà Nội',N'Sinh viên','...','DG002','123')
insert into tblDocGia values ('DG003',N'Vũ Sỹ Tùng',N'Nam','15/01/2000','0978633224',N'96 Định Công, Hà Nội',N'Sinh viên','...','DG003','123')
insert into tblDocGia values ('DG004',N'Trần Đức Nam',N'Nam','11/03/2001','0974551224',N'96 Định Công, Hà Nội',N'Sinh viên','...','DG004','123')
insert into tblDocGia values ('DG005',N'Nguyễn Thị Hà',N'Nữ','23/10/1999','0974688824',N'96 Định Công, Hà Nội',N'Sinh viên','...','DG005','123')

select * from tblDocGia

-- chèn dữ liệu thủ thư
insert into tblThuThu values ('TT001',N'Đỗ Thanh Long',N'Nam','15/06/2001','0974633324',N'Thanh Xuân, Hà Nội','TT001','123')
insert into tblThuThu values ('TT002',N'Nguyễn Như Ý',N'Nữ','15/05/1999','0974633324',N'Thanh Xuân, Hà Nội','TT002','123')
insert into tblThuThu values ('TT003',N'Vũ Anh Vân',N'Nữ','15/07/1999','0974633324',N'Thanh Xuân, Hà Nội','TT003','123')

select * from tblThuThu


--chèn dữ liệu tài liệu
insert into tblTaiLieu values ('TL001',N'Lập Trình Website',N'Công Nghệ',N'Trần Tiến Dũng',N'NXB Giáo Dục','2010','90000','...')
insert into tblTaiLieu values ('TL002',N'Nhà Đầu Tư Thông Minh',N'Kinh Tế',N'Benjamin Graham',N'NXB Thế Giới','1949','200000','...')
insert into tblTaiLieu values ('TL003',N'Lập Trình C#',N'Công Nghệ',N'Trịnh Thị Xuân',N'NXB Giáo Dục','2014','80000','...')
insert into tblTaiLieu values ('TL004',N'Úng Dụng Công Nghệ',N'Khoa Học',N'Trương Tiến Tùng',N'NXB Khoa Học','2019','50000','...')
insert into tblTaiLieu values ('TL005',N'Số Đỏ',N'Tiểu Thuyết',N'Vũ Trọng Phụng',N'NXB Kim Đồng','2001','120000','...')

select * from tblTaiLieu
delete from tblTaiLieu