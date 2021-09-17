package com.cm.jpa_boot_01.repository;

import com.cm.jpa_boot_01.model.Board;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BoardRepository extends JpaRepository<Board, Long> {
}
