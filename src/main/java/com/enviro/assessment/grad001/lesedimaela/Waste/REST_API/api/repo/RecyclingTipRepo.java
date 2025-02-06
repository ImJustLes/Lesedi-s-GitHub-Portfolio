package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.RecyclingTip;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

//Repo used to make database operations for the Recycling Tips table
@Repository
public interface RecyclingTipRepo extends JpaRepository<RecyclingTip, Long> {
}
