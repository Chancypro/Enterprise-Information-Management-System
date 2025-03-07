/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80018
 Source Host           : localhost:3306
 Source Schema         : db_22331099

 Target Server Type    : MySQL
 Target Server Version : 80018
 File Encoding         : 65001

 Date: 19/01/2025 21:32:14
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for customer_info
-- ----------------------------
DROP TABLE IF EXISTS `customer_info`;
CREATE TABLE `customer_info`  (
  `CustomerID` int(11) NOT NULL AUTO_INCREMENT COMMENT '客户编号，主键、自增长',
  `CustomerName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '客户姓名',
  `Company` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '单位',
  `Sex` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '性别',
  `Age` int(11) NULL DEFAULT NULL COMMENT '年龄',
  `Telephone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '联系电话',
  `Address` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '联系地址',
  PRIMARY KEY (`CustomerID`) USING BTREE,
  INDEX `idx1`(`CustomerName` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of customer_info
-- ----------------------------
INSERT INTO `customer_info` VALUES (1, '客户a1', '建筑公司b', '女', 25, '13345768397', '北街12');
INSERT INTO `customer_info` VALUES (2, '客户b', '医药b', '女', 23, '13578674551', '东门a区');
INSERT INTO `customer_info` VALUES (3, '客户c', '教育业c', '男', 45, '16356918864', '南区3栋');
INSERT INTO `customer_info` VALUES (4, '客户d', '金融d', '女', 56, '13456763356', '西区a单元');
INSERT INTO `customer_info` VALUES (5, '客户e', '制造类2', '男', 33, '15446895673', '中区b花园');
INSERT INTO `customer_info` VALUES (6, '客户f', 'x大学', '女', 20, '13456667857', 'x大学东区');

-- ----------------------------
-- Table structure for dept_info
-- ----------------------------
DROP TABLE IF EXISTS `dept_info`;
CREATE TABLE `dept_info`  (
  `dept_no` int(11) NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `dept_peoplecount` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`dept_no`) USING BTREE,
  INDEX `idx1`(`dept_name` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dept_info
-- ----------------------------
INSERT INTO `dept_info` VALUES (1, '部门1', 1);
INSERT INTO `dept_info` VALUES (2, '部门22', 3);
INSERT INTO `dept_info` VALUES (3, '部门3', 0);

-- ----------------------------
-- Table structure for ed_info
-- ----------------------------
DROP TABLE IF EXISTS `ed_info`;
CREATE TABLE `ed_info`  (
  `ed_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_no` int(11) NULL DEFAULT NULL,
  `dept_no` int(11) NULL DEFAULT NULL,
  `Ed_entrydate` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Ed_leavedate` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Ed_Status` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ed_id`) USING BTREE,
  INDEX `idx1`(`ed_id` ASC) USING BTREE,
  INDEX `emp_no`(`emp_no` ASC) USING BTREE,
  INDEX `dept_no`(`dept_no` ASC) USING BTREE,
  CONSTRAINT `ed_info_ibfk_1` FOREIGN KEY (`emp_no`) REFERENCES `emp_info` (`emp_no`) ON DELETE SET NULL ON UPDATE SET NULL,
  CONSTRAINT `ed_info_ibfk_2` FOREIGN KEY (`dept_no`) REFERENCES `dept_info` (`dept_no`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of ed_info
-- ----------------------------
INSERT INTO `ed_info` VALUES (1, 1, 2, '2019-09-04', '', 1);
INSERT INTO `ed_info` VALUES (2, 2, 2, '2020-04-26', '', 1);
INSERT INTO `ed_info` VALUES (3, 2, 1, '2018-08-03', '2020-01-16', 2);
INSERT INTO `ed_info` VALUES (4, 1, 1, '2015-06-04', '2020-04-05', 2);
INSERT INTO `ed_info` VALUES (5, 3, 2, '2023-06-21', '', 1);

-- ----------------------------
-- Table structure for emp_info
-- ----------------------------
DROP TABLE IF EXISTS `emp_info`;
CREATE TABLE `emp_info`  (
  `emp_no` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `last_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `gender` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `hire_date` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `birthday` varchar(22) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `address` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `telephone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`emp_no`) USING BTREE,
  INDEX `idx1`(`first_name` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of emp_info
-- ----------------------------
INSERT INTO `emp_info` VALUES (1, 'eee', 'e', '女', '2020-01-06', '2000-01-07', '地球', '1');
INSERT INTO `emp_info` VALUES (2, '小白', '李', '男', '2005-01-02', '2025-01-16', '中国', '445454666');
INSERT INTO `emp_info` VALUES (3, 'aaa', 'ccc', '男', '2010-01-01', '2000-01-01', '月球', '222333');
INSERT INTO `emp_info` VALUES (4, 'qqq', 'q', '男', '2020-01-06', '2000-01-07', '木星', '222222');
INSERT INTO `emp_info` VALUES (5, 'eee', 'b', '女', '2022-01-07', '2000-01-08', '海王星', '342434');

-- ----------------------------
-- Table structure for user_info
-- ----------------------------
DROP TABLE IF EXISTS `user_info`;
CREATE TABLE `user_info`  (
  `UserID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID，主键、自增长',
  `UserName` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '用户名',
  `Password` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '密码\r',
  `Age` int(11) NULL DEFAULT NULL COMMENT '年龄',
  `Sex` int(11) NULL DEFAULT NULL COMMENT '性别',
  PRIMARY KEY (`UserID`) USING BTREE,
  INDEX `idx1`(`UserName` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user_info
-- ----------------------------
INSERT INTO `user_info` VALUES (1, '用户6', '123', 16, 2);
INSERT INTO `user_info` VALUES (2, 'a', '123', 10, 1);

-- ----------------------------
-- Function structure for count_people
-- ----------------------------
DROP FUNCTION IF EXISTS `count_people`;
delimiter ;;
CREATE FUNCTION `count_people`(d int)
 RETURNS int(11)
begin
declare g int default 0;
SELECT COUNT(dept_no)  FROM ed_info WHERE dept_no=d and ed_status = 1 into g;
return g;
end
;;
delimiter ;

-- ----------------------------
-- Function structure for hello
-- ----------------------------
DROP FUNCTION IF EXISTS `hello`;
delimiter ;;
CREATE FUNCTION `hello`()
 RETURNS varchar(64) CHARSET utf8mb4
begin 
    declare str varchar(64);  
    set str = 'hello world'; 
    return str; 
end
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table ed_info
-- ----------------------------
DROP TRIGGER IF EXISTS `tri_update`;
delimiter ;;
CREATE TRIGGER `tri_update` AFTER INSERT ON `ed_info` FOR EACH ROW # 触发器主体 
UPDATE dept_info SET dept_info.dept_peoplecount = dept_info.dept_peoplecount + 1 WHERE dept_info.dept_no = NEW.dept_no
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
