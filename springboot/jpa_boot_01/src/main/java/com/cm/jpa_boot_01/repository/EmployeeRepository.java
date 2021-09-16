package com.cm.jpa_boot_01.repository;

import com.cm.jpa_boot_01.model.Employee;
import org.springframework.data.jpa.repository.JpaRepository;

public interface EmployeeRepository extends JpaRepository<Employee, Long> {

}